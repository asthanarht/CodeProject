﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPMobile.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using Xamarin.Forms;
using CPMobile.Service;
using CPMobile.Helper;


[assembly: Dependency(typeof(CPFeedService))]
namespace CPMobile.Service
{
    public class CPFeedService :ICPFeeds
    {
        bool initialized = false;

        static string clientId = "WRymObjweyg9fj78Z5FV3R-uHeoVt_Oh";
        static string clientSecret = "NQyjvo7N7eN06Xu9nTHm4jRt0X7IZThNwPAKVnp9GBcOZKm89xIOhbeOIQrOXVJj";
        static string baseUrl = "https://api.codeproject.com/";
        
        public CPFeedService()
        {

        }

        public async Task Init()
        {
            initialized = true;
            if (!String.IsNullOrEmpty(Settings.AuthToken))
            {
                GetArticleAsync(1);
                return;
            }
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);

                // We want the response to be JSON.
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                // Build up the data to POST.
                List<KeyValuePair<string, string>> postData = new List<KeyValuePair<string, string>>();
                postData.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));
                postData.Add(new KeyValuePair<string, string>("client_id", clientId));
                postData.Add(new KeyValuePair<string, string>("client_secret", clientSecret));
                FormUrlEncodedContent content = new FormUrlEncodedContent(postData);
                // Post to the Server and parse the response.
                try
                {
                    var response = await client.PostAsync("Token", content);
                    response.EnsureSuccessStatusCode();
                    string jsonString = response.Content.ReadAsStringAsync().Result;
                    CPAuthToken responseData = JsonHelper.Deserialize<CPAuthToken>(jsonString);

                    Settings.AuthToken = responseData.access_token;
                    
                    var t = "";
                    GetArticleAsync(1);
                    // return the Access Token.
                    //return responseData.ToString();
                }
                catch (Exception ex)
                {

                    initialized = false;
                }

            }
        }

        public async Task<IEnumerable<Item>> GetArticleAsync(int page)
        {
            if (!initialized)
                await Init();
            var accessToken = Settings.AuthToken;

            if (!string.IsNullOrEmpty(accessToken))
            {

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // Add the Authorization header with the AccessToken.
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);

                    // create the URL string.
                    string url = string.Format("v1/Articles?page={0}", page);

                    // make the request
                    HttpResponseMessage response = await client.GetAsync(url);

                    // parse the response and return the data.
                    string jsonString = await response.Content.ReadAsStringAsync();
                    CPFeed responseData = JsonHelper.Deserialize<CPFeed>(jsonString);
                    return responseData.items;
                }
            }
            else
            {
                Init();
                return null;
            }
        }

        public Task<CPFeed> GetForumAsync()
        {
            throw new NotImplementedException();
        }


        public async Task<bool> GetAccessToken(string username, string password)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);

                // We want the response to be JSON.
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                // Build up the data to POST.
                List<KeyValuePair<string, string>> postData = new List<KeyValuePair<string, string>>();
                postData.Add(new KeyValuePair<string, string>("grant_type", "password"));
                postData.Add(new KeyValuePair<string, string>("client_id", clientId));
                postData.Add(new KeyValuePair<string, string>("client_secret", clientSecret));
                postData.Add(new KeyValuePair<string, string>("username", username));
                postData.Add(new KeyValuePair<string, string>("password", password));
                FormUrlEncodedContent content = new FormUrlEncodedContent(postData);
                // Post to the Server and parse the response.
                try
                {
                    var response = await client.PostAsync("Token", content);
                    response.EnsureSuccessStatusCode();
                    string jsonString = response.Content.ReadAsStringAsync().Result;

                    //object responseData = JsonConvert.DeserializeObject(jsonString);
                    Login responseData = JsonHelper.Deserialize<Login>(jsonString);

                    Settings.AuthLoginToken = responseData.access_token;


                    return true;
                    // return the Access Token.
                    //return responseData.ToString();
                }
                catch (Exception ex)
                {

                    initialized = false;
                    return false;
                }
                return false;

            }
        }


    }
}

