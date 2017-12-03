using System;
using _17NSJ.iOS.Effects;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("_17NSJ")]
[assembly: ExportEffect(typeof(LineBreakLabelEffect), "LineBreakLabelEffect")]
namespace _17NSJ.iOS.Effects
{
    public class LineBreakLabelEffect: PlatformEffect
    {
        protected override void OnAttached()
        {
            var label = Control as UILabel;

            if (label == null) { return; }
            label.LineBreakMode = UILineBreakMode.TailTruncation;
            label.Lines = 2;
        }

        protected override void OnDetached()
        {
        }
    }
}
