using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using CPMobile.Views;
using CPMobile.Models;

namespace CPMobile
{
	public class App : Application, ILoginManager
	{
        // https://gist.github.com/ChaseFlorell/32e1f5c1187d2a7e4835
		public static App Current;
        public static Color BrandColor = Color.FromHex("#9B2202");
        public App()
        {
            // The root page of your application
            // The root page of your application
            //Current = this;
           // MainPage = new Profile();

            MainPage = new LoginPage();
            //var isLoggedIn = Properties.ContainsKey("IsLoggedIn")?(bool)Properties ["IsLoggedIn"]:false;

            // we remember if they're logged in, and only display the login page if they're not
            //if (isLoggedIn)
            //    MainPage = new RootPage ();
            //else
            //    MainPage = new RootPage();
        }

		#region ILoginManager implementation

		public void ShowRootPage ()
		{
            new RootPage();
		}

		public void LogOut ()
		{
			Properties ["IsLoggedIn"] = false;
			//new LoginPage (this);
		}

		#endregion

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
