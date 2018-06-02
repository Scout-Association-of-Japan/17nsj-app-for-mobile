using System;
using System.Runtime.Remoting.Contexts;
using _17NSJ.Droid.Platforms;
using _17NSJ.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(AssemblyService))]
namespace _17NSJ.Droid.Platforms
{
    public class AssemblyService : IAssemblyService
    {
        //アプリ名称を取得する
        public string GetPackageName()
        {
            var context = Android.App.Application.Context;
            var name = context.PackageManager.GetPackageInfo(context.PackageName, 0).PackageName;
            return name;
        }

        //アプリバージョン文字列を取得する
        public string GetVersionName()
        {
            var context = Android.App.Application.Context;
            var name = context.PackageManager.GetPackageInfo(context.PackageName, 0).VersionName;
            return name;
        }

        //アプリバージョンコードを取得する
        public string GetBuildName()
        {
            var context = Android.App.Application.Context;
            var code = context.PackageManager.GetPackageInfo(context.PackageName, 0).VersionCode;
            return code.ToString();
        }
    }
}
