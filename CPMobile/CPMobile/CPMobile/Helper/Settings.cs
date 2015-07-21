using System;
using Refractored.Xam.Settings;
using Refractored.Xam.Settings.Abstractions;
namespace CPMobile.Helper
{
    public static class Settings
    {
        public static ISettings AppSettings
        {
            get { return CrossSettings.Current; }
        }

        private static string authToken = string.Empty;

        public static string AuthToken
        {
            get { return AppSettings.GetValueOrDefault<string>(authToken); }
            set { AppSettings.AddOrUpdateValue<string>(authToken,value);}
        }
    }
}
