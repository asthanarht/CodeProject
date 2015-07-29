﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using ImageCircle.Forms.Plugin.Abstractions;
using Xamarin.Forms;

namespace CPMobile.Views
{

    public class Profile : ContentPage
    {
        
        public Profile()
        {
            NavigationPage.SetHasNavigationBar(this, true);
            Title = "Profile";
            BackgroundColor = Color.White;

            var backgroundImage = new Image()
            {
                BackgroundColor = Color.Red,
                Aspect = Aspect.AspectFill,
                IsOpaque = true,
                Opacity = 0.8,
            };

            var shader = new BoxView()
            {
                Color = Color.Black.MultiplyAlpha(.5),
            };

            var face = new CircleImage
            {
                BorderColor = AppStyle.BrandColor,
                BorderThickness = 2,
                HeightRequest = 100,
                WidthRequest = 100,
                Aspect = Aspect.AspectFill,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Source =
                    new UriImageSource {Uri = new Uri("http://bit.ly/1s07h2W"), CacheValidity = TimeSpan.FromDays(30)},
            };

            var dome = new Image()
            {
                Aspect = Aspect.AspectFill,
                Source = new FileImageSource() { File = "dome.png" }
            };

            var chatimage = new Image()
            {
                Source = new FileImageSource() { File = "chat.png" }
            };

            var pindropimage = new Image()
            {
                Source = new FileImageSource() { File = "pindrop.png" }
            };

            var details = new DetailsView();
            var slideshow = new ShowProfileDetailsView();

            RelativeLayout relativeLayout = new RelativeLayout()
            {
                HeightRequest = 100,
            };

            relativeLayout.Children.Add(
                backgroundImage,
                Constraint.Constant(0),
                Constraint.Constant(0),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height * .35;
                })
            );

            relativeLayout.Children.Add(
                shader,
                Constraint.Constant(0),
                Constraint.Constant(0),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height * .35;
                })
            );

            relativeLayout.Children.Add(
                dome,
                Constraint.Constant(-10),
                Constraint.RelativeToParent((parent) =>
                {
                    return (parent.Height * .35) - 50;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width + 10;
                }),
                Constraint.Constant(75)
            );

            relativeLayout.Children.Add(
                chatimage,
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width * .05;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return (parent.Height * .35);
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width * .15;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width * .15;
                })
            );

            relativeLayout.Children.Add(
                pindropimage,
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width * .95 - (parent.Width * .15);
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return (parent.Height * .35);
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width * .15;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width * .15;
                })
            );

            relativeLayout.Children.Add(
                face,
                Constraint.RelativeToParent((parent) =>
                {
                    return ((parent.Width / 2) - (face.Width / 2));
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height * .1;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width * .5;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width * .5;
                })
            );

            relativeLayout.Children.Add(
                details,
                Constraint.Constant(0),
                Constraint.RelativeToView(dome, (parent, view) =>
                {
                    return view.Y + view.Height + 10;
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width;
                }),
                Constraint.Constant(120)
            );

            relativeLayout.Children.Add(
                    slideshow,
                    Constraint.Constant(0),
                    Constraint.RelativeToView(details, (parent, view) =>
                    {
                        return view.Y + view.Height;
                    }),
                    Constraint.RelativeToParent((parent) =>
                    {
                        return parent.Width;
                    }),
                    Constraint.RelativeToView(details, (parent, view) =>
                    {
                        var detailsbottomY = view.Y + view.Height;
                        return parent.Height - detailsbottomY;
                    })
                );

            face.SizeChanged += (sender, e) =>
            {
                relativeLayout.ForceLayout();
            };

            this.Content = relativeLayout;
          
        }
    }
}
