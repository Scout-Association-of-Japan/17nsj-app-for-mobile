using Android.Widget;
using _17NSJ.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using _17NSJ.Droid.Renderer;

[assembly: ExportRenderer(typeof(NonSeparatorTableView), typeof(NonSeparatorTableViewRenderer))]
namespace _17NSJ.Droid.Renderer
{
    public class NonSeparatorTableViewRenderer: TableViewRenderer
     {
         protected override void OnElementChanged(ElementChangedEventArgs<TableView> e)
         {
             base.OnElementChanged(e);
 
             if (Control == null)
                 return;
 
             var listView = Control as global::Android.Widget.ListView;
             listView.DividerHeight = 0;
         }
     }
}
