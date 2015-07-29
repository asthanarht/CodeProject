using CPMobile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CPMobile.Views
{
    public class MenuTableView :TableView
    {

    }
    public class MenuPage :ContentPage
    {
        public ListView Menu { get; set; }
        RootPage rootPage;
        TableView tableView;
        
        public MenuPage(RootPage rootPage)
        {
            Icon = "settings.png";
            Title = "menu"; // The Title property must be set.

            this.rootPage = rootPage;
        
			var logoutButton = new Button { Text = "Logout" };
			logoutButton.Clicked += (sender, e) => {
				App.Current.LogOut();
			};
            var layout = new StackLayout
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromHex("2C3E50"),
            };
            var section = new TableSection()
            {
                new MenuCell {Text = "Home",Host= this},
                new MenuCell {Text = "Favorites",Host= this},
                new MenuCell {Text = "About",Host= this},
                new MenuCell {Text = "Contact",Host= this},
            };
            var root = new TableRoot() { section };

            tableView = new MenuTableView()
            {
                Root = root,
                Intent = TableIntent.Data,
                BackgroundColor = Color.FromHex("2C3E50"),
            };

            
            layout.Children.Add(new SettingsUserView());
            //layout.Children.Add(new BoxView()
            //{
            //    HeightRequest = 1,
            //    BackgroundColor = AppStyle.DarkLabelColor,
            //});
            layout.Children.Add(tableView);
			layout.Children.Add(logoutButton);
            
            Content = layout;
        }

        NavigationPage home, favorite, favorites;
        public void Selected(string item)
        {

            switch (item)
            {
                case "Home":
                    if (home == null)
                        home = new NavigationPage(new RootPage());
                    //rootPage.Detail = home;
                    break;
                case "Favorites":
                    if (favorites == null)
                        favorites = new NavigationPage(new Profile()) { BarBackgroundColor = App.BrandColor };
                    rootPage.Detail = favorites;
                    break;
                case "Room Plan":
                    rootPage.Detail = new NavigationPage(new RootPage());// { BarBackgroundColor = App.NavTint };
                    break;
                case "Contact":
                    rootPage.Detail = new NavigationPage(new RootPage());// { BarBackgroundColor = App.NavTint };
                    break;
                case "About":
                    rootPage.Detail = new NavigationPage(new RootPage());// { BarBackgroundColor = App.NavTint };
                    break;
            };
            rootPage.IsPresented = false;  // close the slide-out
        }	

    }

    
}
