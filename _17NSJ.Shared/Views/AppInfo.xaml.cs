using System;
using System.Collections.Generic;
using _17NSJ.Interfaces;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class AppInfo : ContentPage
    {
        public AppInfo()
        {
            InitializeComponent();

            appName.Text = "アプリ名:" + DependencyService.Get<IAssemblyService>().GetPackageName();
            appVer.Text = "Version:" +DependencyService.Get<IAssemblyService>().GetVersionName();
            buildVer.Text = "Build:" +DependencyService.Get<IAssemblyService>().GetBuildName();
        }
    }
}
