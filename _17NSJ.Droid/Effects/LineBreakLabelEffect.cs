using System;
using _17NSJ.Droid.Effects;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("_17NSJ")]
[assembly: ExportEffect(typeof(LineBreakLabelEffect), "LineBreakLabelEffect")]
namespace _17NSJ.Droid.Effects
{
    public class LineBreakLabelEffect: PlatformEffect
    {
        protected override void OnAttached()
        {
            Control.LayoutChange += (s, args) =>
            {
                var label = Control as TextView;

                if (label == null) { return; }

                label.Ellipsize = Android.Text.TextUtils.TruncateAt.End;
                label.SetMaxLines(2);
            };
        }

        protected override void OnDetached()
        {
        }
    }
}
