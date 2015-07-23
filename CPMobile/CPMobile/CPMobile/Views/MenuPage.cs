using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CPMobile.Views
{
    public class MenuPage :ContentPage
    {
        public ListView Menu { get; set; }

        public MenuPage()
        {
            Icon = "settings.png";
            Title = "menu"; // The Title property must be set.
            BackgroundColor = Color.FromHex("333333");

            Menu = new MenuListView();

          

			var logoutButton = new Button { Text = "Logout" };
			logoutButton.Clicked += (sender, e) => {
				App.Current.LogOut();
			};
            var layout = new StackLayout
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            layout.Children.Add(new SettingsUserView());
            layout.Children.Add(new BoxView()
            {
                HeightRequest = 1,
                BackgroundColor = AppStyle.DarkLabelColor,
            });
            layout.Children.Add(Menu);
			layout.Children.Add(logoutButton);
            Content = layout;
        }
    }

    public class MenuListView : ListView
    {
        public MenuListView()
        {
            List<MenuItem> data = new MenuListData();

            ItemsSource = data;
            VerticalOptions = LayoutOptions.FillAndExpand;
            BackgroundColor = Color.Transparent;
            
            //SeparatorVisibility = SeparatorVisibility.None;

            var cell = new DataTemplate(typeof(MenuCell));
            cell.SetBinding(MenuCell.TextProperty, "Title");
            cell.SetBinding(MenuCell.ImageSourceProperty, "IconSource");
            
            ItemTemplate = cell;
        }
    }

    public class MenuListData : List<MenuItem>
    {
        public MenuListData()
        {
            this.Add(new MenuItem()
            {
                Title = "Home",
                IconSource = "contacts.png",
                TargetType = typeof(RootPage)
            });

            this.Add(new MenuItem()
            {
                Title = "Leads",
                IconSource = "leads.png",
                TargetType = typeof(LoginPage)
            });

            this.Add(new MenuItem()
            {
                Title = "Accounts",
                IconSource = "accounts.png",
                TargetType = typeof(LoginPage)
            });

            this.Add(new MenuItem()
            {
                Title = "Opportunities",
                IconSource = "opportunities.png",
                TargetType = typeof(LoginPage)
               
            });
        }
    }
    public class MenuCell : ImageCell
    {
        public MenuCell()
            : base()
        {
            this.TextColor = Color.FromHex("AAAAAA");
            
        }
    }

    public class MenuItem
    {
        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }
    }
}
