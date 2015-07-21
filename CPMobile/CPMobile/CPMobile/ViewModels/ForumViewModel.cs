using CPMobile.Style;
using CPMobile.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPMobile.ViewModels
{
    public class ForumViewModel : ICarouselViewModel
    {
        public Xamarin.Forms.ContentView View
        {
            get { return new ForumListPage(); }
        }


        public string TabText
        {
            get { return "Forum"; }
        }
    }
}
