using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace CPMobile
{
    public class ShowProfileDetailsView : ContentView
    {
        public ShowProfileDetailsView()
        {
            HeightRequest = 200;

            var article = new Label()
            {
                Text = "Article",
                FontSize = 20,
                FontFamily = Device.OnPlatform("HelveticaNeue-Bold", "sans-serif-black", null),
                XAlign = TextAlignment.Center,
                TextColor = Color.Black
            };

            var articleCount = new Label()
            {
                Text = "4",
                FontSize = 14,
                FontFamily = Device.OnPlatform("HelveticaNeue", "sans-serif", null),
                XAlign = TextAlignment.Center,
                TextColor = Color.Black
            };

            var stackArticle = new StackLayout()
            {
                Padding = new Thickness(20, 10),
                Children = {
					article,
					articleCount,
				}
            };
            var techBlog = new Label()
            {
                Text = "Technical Blog",
                FontSize = 18,
                FontFamily = Device.OnPlatform("HelveticaNeue-Bold", "sans-serif-black", null),
                XAlign = TextAlignment.Center,
                TextColor = Color.Black
            };

            var techBlogCount = new Label()
            {
                Text = "40",
                FontSize = 14,
                FontFamily = Device.OnPlatform("HelveticaNeue", "sans-serif", null),
                XAlign = TextAlignment.Center,
                TextColor = Color.Black
            };

            var stackBlog = new StackLayout()
            {
                Padding = new Thickness(20, 10),
                Children = {
					techBlog,
					techBlogCount,
				}
            };
            var message = new Label()
            {
                Text = "Message",
                FontSize = 20,
                FontFamily = Device.OnPlatform("HelveticaNeue-Bold", "sans-serif-black", null),
                XAlign = TextAlignment.Center,
                TextColor = Color.Black
            };

            var messageCount = new Label()
            {
                Text = "184",
                FontSize = 14,
                FontFamily = Device.OnPlatform("HelveticaNeue", "sans-serif", null),
                XAlign = TextAlignment.Center,
                TextColor = Color.Black
            };

            var stackMessage = new StackLayout()
            {
                Padding = new Thickness(20, 10),
                Children = {
					message,
					messageCount,
				}
            };
            var tip = new Label()
            {
                Text = "Tip&Trick",
                FontSize = 20,
                FontFamily = Device.OnPlatform("HelveticaNeue-Bold", "sans-serif-black", null),
                XAlign = TextAlignment.Center,
                TextColor = Color.Black
            };

            var tipCount = new Label()
            {
                Text = "24",
                FontSize = 14,
                FontFamily = Device.OnPlatform("HelveticaNeue", "sans-serif", null),
                XAlign = TextAlignment.Center,
                TextColor = Color.Black
            };

            var stackTip = new StackLayout()
            {
                Padding = new Thickness(20, 10),
                Children = {
					tip,
					tipCount,
				}
            };
            var comments = new Label()
            {
                Text = "Comment",
                FontSize = 20,
                FontFamily = Device.OnPlatform("HelveticaNeue-Bold", "sans-serif-black", null),
                XAlign = TextAlignment.Center,
                TextColor = Color.Black
            };

            var commentsCount = new Label()
            {
                Text = "84",
                FontSize = 14,
                FontFamily = Device.OnPlatform("HelveticaNeue", "sans-serif", null),
                XAlign = TextAlignment.Center,
                TextColor = Color.Black
            };

            var stackComments = new StackLayout()
            {
                HeightRequest = 200,
                Padding = new Thickness(20, 10),
                Children = {
					comments,
					commentsCount,
				}
            };



            //overall

            var stack = new StackLayout () {
				Padding = new Thickness(0,0,0,10),
				Orientation = StackOrientation.Horizontal,
				Spacing = 10,
				Children = {
					stackArticle,
					stackBlog,
					stackMessage,
					stackTip,
					stackComments,
				}
			};

			Content = new ScrollView() {
				Content = stack, 
				Orientation = ScrollOrientation.Horizontal};
        }
    }
}
