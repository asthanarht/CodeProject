using CPMobile.Style;
using CPMobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CPMobile.Views
{
    public class ArticleListPage:ContentView
    {
        ArticleViewModel articleViewModel;
        public ArticleListPage()
        {
           articleViewModel = new ArticleViewModel();
           articleViewModel.GetCPFeedCommand.Execute(null);
            var activityIndicator = new ActivityIndicator
            {
                Color = Color.White,
            };
            activityIndicator.SetBinding(ActivityIndicator.IsVisibleProperty, "IsBusy");
            activityIndicator.SetBinding(ActivityIndicator.IsRunningProperty, "IsBusy");
            var vetlist = new ListView
            {
                HasUnevenRows = true,
                ItemTemplate = new DataTemplate(typeof(CPListCell)),
                ItemsSource = articleViewModel.Articles,
                BackgroundColor = Color.White,
            };
            //vetlist.SetBinding<ArticlePageViewModel>();
             Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.White,
                Children = { vetlist  }
            };

             vetlist.ItemSelected += (sender, e) =>
             {
                // Navigation.PushAsync( );
             };
           
        }

      
    }
}
