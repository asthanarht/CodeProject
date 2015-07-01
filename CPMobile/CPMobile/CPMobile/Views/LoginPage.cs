using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CPMobile.Views
{
    public class LoginPage : ContentPage
    {
        public LoginPage()
        {
          //  BackgroundColor = Color.Blue;
            BackgroundImage =  "orange.jpg";
            var layout = new StackLayout { Padding = 20 };
            var label = new Label
            {
                Text = "CodeProject For Developer",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                TextColor = Color.White,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,

            };

            var backgroundImage = new Image()
            {
                Aspect = Xamarin.Forms.Aspect.Fill,
                Source = FileImageSource.FromFile("orange.jpg")
            };

            layout.Children.Add(label);

            var username = new Entry { Placeholder = "UserName" };
            layout.Children.Add(username);

            var password = new Entry { Placeholder = "Password",IsPassword=true };

            layout.Children.Add(password);
            var relativelayout = new RelativeLayout();

            var button = new Button { Text = "Log In", TextColor = Color.White };

            layout.Children.Add(button);
            relativelayout.Children.Add(backgroundImage,
                Constraint.Constant(0),
                Constraint.Constant(0),
                Constraint.RelativeToParent((parent)=>{return parent.Width;}),
                Constraint.RelativeToParent((parent)=>{return parent.Height;}));

            relativelayout.Children.Add(layout,
                Constraint.Constant(0),
                Constraint.Constant(0),
                Constraint.RelativeToParent((parent)=>{return parent.Width;}),
                Constraint.RelativeToParent((parent)=>{return parent.Height;}));


            Content = new ScrollView { Content = relativelayout };

           

         
        }
    }
}
