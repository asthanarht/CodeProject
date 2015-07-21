using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CPMobile.Style
{
    public class DynamicTemplateLayout : ViewCell
    {

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var vm = BindingContext as ICarouselViewModel;
            var page = vm.View;
            page.BindingContext = vm;
            View = page;
        }
    }

    public interface ICarouselViewModel
    {
        ContentView View { get; }
        string TabText { get;  }
    }
}
