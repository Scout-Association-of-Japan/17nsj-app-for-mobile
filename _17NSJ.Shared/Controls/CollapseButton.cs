using System;
using Xamarin.Forms;

namespace _17NSJ.Controls
{
    public class CollapseButton : Button
    {
        public CollapseButton(): base()
        {
            const int _animationTime = 100;

            Pressed += async (sender, e) =>
            {
                var btn = sender as CollapseButton;

                if (btn != null)
                {
                    await btn.ScaleTo(0.5, _animationTime);
                    await btn.ScaleTo(1, _animationTime);
                }
            };
        }
    }
}
