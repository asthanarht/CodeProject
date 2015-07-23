using CPMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CPMobile.ViewModels
{
    public class ArticleViewModel:BaseViewModel
    {
        readonly ICPFeeds cpFeed;

        public ObservableCollection<Item> Articles { get; set; }
        public ArticleViewModel()
        {
            cpFeed = DependencyService.Get<ICPFeeds>();
            Title = "CodeProject";
            Icon = "icon.png";
            Articles = new ObservableCollection<Item>();
        }

        public void CallInit()
        {
            ExecuteInit();
        }

        private async Task ExecuteInit()
        {
            await cpFeed.Init();
        }

        private Command getCPFeedCommand;
        public Command GetCPFeedCommand
        {
            get
            {
                return getCPFeedCommand ??
                    (getCPFeedCommand = new Command(async () => await ExecuteGetCPFeedCommand(), () => { return !IsBusy; }));
            }
        }



        private async Task ExecuteGetCPFeedCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            GetCPFeedCommand.ChangeCanExecute();

            try
            {
                var articles = await cpFeed.GetArticleAsync(1);
                foreach(var article in articles)
                {
                    Articles.Add(article);
                }
                IsBusy = false;
            }
            catch(Exception ex)
            {

            }
        }
    }
}
