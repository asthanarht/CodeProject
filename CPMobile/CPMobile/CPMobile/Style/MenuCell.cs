using CPMobile.Views;
using Xamarin.Forms;

namespace CPMobile
{
    public class MenuCell : ViewCell
    {
        public string Text
        {
            get { return label.Text; }
            set { label.Text = value; }
        }
        Label label;

        public ImageSource ImageSrc
        {
            get { return image.Source; }
            set { image.Source = value; }
        }
        Image image;

        public MenuPage Host { get; set; }

        public MenuCell()
        {
            image = new Image {
                HeightRequest = 15,
                WidthRequest = 15,
            };
           // image.SetBinding(Image.SourceProperty, ImageSrc);

            label = new Label
            {
                YAlign = TextAlignment.Center,
                TextColor = Color.White,
            };

            var layout = new StackLayout
            {
                BackgroundColor = Color.FromHex("2C3E50"),
                Padding = new Thickness(20, 0, 0, 0),
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Children = { image,label }
            };
            View = layout;
        }

        protected override void OnTapped()
        {
            base.OnTapped();

            Host.Selected(label.Text);
        }
    }
}
