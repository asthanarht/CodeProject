using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using CPMobile.Style;
namespace CPMobile.Views
{
    public class MainListPage : ContentPage
    {

        public MainListPage()
        {
            var vetlist = new ListView
            {
                HasUnevenRows = true,
                ItemTemplate = new DataTemplate(typeof(MainListCell)),
                ItemsSource = CPMobile.Style.MainListCell.VetData.GetData(),
                BackgroundColor= Color.White,
               // SeparatorColor = Color.FromHex("#ddd"),
            };

            Content = new ScrollView { Content = vetlist };
        }
    }
    
}
