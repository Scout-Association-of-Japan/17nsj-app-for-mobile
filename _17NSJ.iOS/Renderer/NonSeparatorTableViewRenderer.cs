using System;
using _17NSJ.Controls;
using _17NSJ.iOS.Renderer;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(NonSeparatorTableView), typeof(NonSeparatorTableViewRenderer))]
namespace _17NSJ.iOS.Renderer
{
    public class NonSeparatorTableViewRenderer : TableViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<TableView> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
                return;

            var tableView = Control as UITableView;
            tableView.SeparatorStyle = UITableViewCellSeparatorStyle.None;
        }
    }
}
