using ImageCircle.Forms.Plugin.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using CPMobile.Views;
using Xamarin.Forms;

namespace CPMobile
{
    public class SettingsUserView : ContentView
    {
        public SettingsUserView()
        {
            var circleImage = new CircleImage
            {
                BorderColor = AppStyle.BrandColor,
                BorderThickness = 2,
                HeightRequest = 80,
                WidthRequest = 80,
                Aspect = Aspect.AspectFill,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Source =
                    new UriImageSource {Uri = new Uri("http://bit.ly/1s07h2W"), CacheValidity = TimeSpan.FromDays(30)},
            };

            Content = new StackLayout()
            {
                Padding = new Thickness(0, 10, 0, 0),
                Spacing = 15,
                Orientation = StackOrientation.Vertical,
                Children = {circleImage,
					new Label () { 
						Text = "Rohit Asthana", 
						TextColor = Color.White,
                        HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.Center,
						},
				}
            };

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped +=
                (sender, e) =>
                    Navigation.PushModalAsync(new NavigationPage(new Profile()) {BarBackgroundColor = App.BrandColor});
            circleImage.GestureRecognizers.Add(tapGestureRecognizer);
            
        }
    }
}
