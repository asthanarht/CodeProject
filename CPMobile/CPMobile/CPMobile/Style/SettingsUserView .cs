using ImageCircle.Forms.Plugin.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Xamarin.Forms;

namespace CPMobile
{
    public class SettingsUserView : ContentView
    {
        public SettingsUserView()
        {
            Content = new StackLayout()
            {
                Padding = new Thickness(0, 10, 0, 0),
                Spacing = 15,
                Orientation = StackOrientation.Vertical,
                Children = {
					new CircleImage {
						BorderColor = AppStyle.BrandColor,
						BorderThickness = 2,
						HeightRequest = 80,
						WidthRequest = 80,
						Aspect = Aspect.AspectFill,
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.Center,
						Source = new UriImageSource { Uri = new Uri ("http://bit.ly/1s07h2W"),CacheValidity=TimeSpan.FromDays(30) },
					},
					new Label () { 
						Text = "Rohit Asthana", 
						TextColor = Color.White,
                        HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.Center,
						},
				}
            };
        }
    }
}
