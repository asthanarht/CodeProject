using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPMobile.Views;

namespace CPMobile.ViewModels
{
    public class ArticlePageViewModel :ICarouselViewModel
    {
        public Xamarin.Forms.ContentView View
        {
            get { return new ArticleListPage(); }
        }


        public string TabText
        {
            get { return "Article"; }
        }
    }
}
