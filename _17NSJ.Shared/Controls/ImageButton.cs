using System;
using Xamarin.Forms;

namespace _17NSJ.Controls
{
    public class ImageButton : Image
    {
        public event EventHandler Tapped;

        /// <summary>
        /// アニメーション時間を取得または設定します。
        /// (デフォルト100ms)
        /// </summary>
        /// <value>アニメーション時間</value>
        public uint? AnimationTime { get; set; }

        /// <summary>
        /// アニメーションの際の凹凸のスケールを取得または設定します。
        /// (デフォルト0.5)
        /// </summary>
        /// <value>アニメーションの際の凹凸のスケール</value>
        public double? UnevennessScale { get; set; }

        public ImageButton() : base()
        {
            var tgr = new TapGestureRecognizer();
            tgr.Tapped += (sender, e) => OnClicked(sender, e);
            this.GestureRecognizers.Add(tgr);
        }

        private async void OnClicked(object sender, EventArgs e)
        {


            var btn = sender as ImageButton;

            if (btn != null)
            {
                uint _animationTime;
                double _unevennessScale;

                // アニメーション時間の指定がなければデフォルト(100ms)
                if (AnimationTime is null)
                {
                    _animationTime = 100;
                }
                else
                {
                    _animationTime = (uint)AnimationTime;
                }

                //凹凸スケールの指定がなければデフォルト値(0.5)
                if (UnevennessScale is null)
                {
                    _unevennessScale = 0.7;
                }
                else
                {
                    _unevennessScale = (double)UnevennessScale;
                }

                await btn.ScaleTo(_unevennessScale, _animationTime);
                await btn.ScaleTo(1, _animationTime);
            }

            // アニメーション後に指定されたメソッドを実行
            if (Tapped != null)
            {
                Tapped(this, e);
            }
        }
    }
}
