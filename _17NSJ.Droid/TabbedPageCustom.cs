using System;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using _17NSJ.Views;
using _17NSJ.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(TabBaseView), typeof(TabbedPageCustom))]
namespace _17NSJ.Droid
{
    public class TabbedPageCustom: TabbedPageRenderer
    {
        public TabbedPageCustom()
        {
        }

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            InvertLayoutThroughScale();

            base.OnLayout(changed, l, t, r, b);
        }

        private void InvertLayoutThroughScale()
        {
            ViewGroup.ScaleY = -1;

            TabLayout tabLayout = null;
            ViewPager viewPager = null;

            for (int i = 0; i < ChildCount; ++i)
            {
                Android.Views.View view = (Android.Views.View)GetChildAt(i);
                if (view is TabLayout) tabLayout = (TabLayout)view;
                else if (view is ViewPager) viewPager = (ViewPager)view;
            }

            tabLayout.ScaleY = viewPager.ScaleY = -1;
            viewPager.SetPadding(0, -tabLayout.MeasuredHeight, 0, 0);

            // タブの背景色
            tabLayout.SetBackgroundColor(Android.Graphics.Color.Rgb(0, 113, 188));

            // 選択されたタブのインジケーター色
            tabLayout.SetSelectedTabIndicatorColor(Android.Graphics.Color.Rgb(247, 147, 30));

            // タブテキスト色
            tabLayout.SetTabTextColors(Android.Graphics.Color.White, Android.Graphics.Color.Rgb(247, 147, 30));
        }
    }
}