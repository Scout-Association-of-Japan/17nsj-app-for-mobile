using System;
using System.Collections.Generic;
using _17NSJ.Interfaces;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class AppInfoView : ContentPage
    {
        int count = 0;

        public AppInfoView()
        {
            // トラッキングコード
            Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "AppInfoView" } });

            InitializeComponent();

            appName.Key = "アプリ名";
            appName.Value = DependencyService.Get<IAssemblyService>().GetPackageName();
            appVer.Key = "Version";
            appVer.Value = DependencyService.Get<IAssemblyService>().GetVersionName();
            buildVer.Key = "Build";
            buildVer.Value = DependencyService.Get<IAssemblyService>().GetBuildName();
        }

        void Handle_Tapped(object sender, System.EventArgs e)
        {
            count++;
            if(count == 10)
            {
                count = 0;
                Navigation.PushAsync(new SecretView());
            }
        }
    }
}
