using Android.App;
using Android.Graphics.Drawables;
using Xamarin.Forms;
using CPMobile.Droid;
using Xamarin.Forms.Platform.Android;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CPMobile.Views;
using CPMobile.Droid.Renderers;

[assembly: ExportRenderer(typeof(MenuTableView), typeof(MenuAndroidTableViewRenderer))]
namespace CPMobile.Droid.Renderers
{
    public class MenuAndroidTableViewRenderer:TableViewRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<TableView> e)
        {
            base.OnElementChanged(e);
            var tableView = Control as global::Android.Widget.ListView;
            tableView.DividerHeight = 0;
            tableView.SetHeaderDividersEnabled(false);
            tableView.SetBackgroundColor(new global::Android.Graphics.Color(0x2C, 0x3E, 0x50));
        }
    }
}