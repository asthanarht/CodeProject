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
		public static App Current;
        public static Color BrandColor = Color.FromHex("#FAA128");
        public App()
        {
            // The root page of your application
            // The root page of your application
            //Current = this;

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
