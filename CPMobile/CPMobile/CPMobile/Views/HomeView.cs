using CPMobile;
using CPMobile.Views;
using System;
using Xamarin.Forms;

namespace CustomLayouts
{
    public class HomeView : ContentView
    {
        public HomeView()
        {
            var vetlist = new ListView
            {
                HasUnevenRows = true,
                ItemTemplate = new DataTemplate(typeof(MainListCell)),
                ItemsSource = CPMobile.MainListCell.VetData.GetData(),
                BackgroundColor = Color.White,
            };

            Content = new ScrollView { Content = vetlist };

            vetlist.ItemSelected += (sender, e) =>
                {
                    Navigation.PushAsync(new LoginPage());
                };
            //BackgroundColor = Color.White;

            //var label = new Label
            //{
            //    XAlign = TextAlignment.Center,
            //    TextColor = Color.Black
            //};

            //label.SetBinding(Label.TextProperty, "Title");
            //this.SetBinding(ContentView.BackgroundColorProperty, "Background");

            //Content = new StackLayout
            //{
            //    VerticalOptions = LayoutOptions.CenterAndExpand,
            //    Children = {
            //        label
            //    }
            //};
        }
    }
}

