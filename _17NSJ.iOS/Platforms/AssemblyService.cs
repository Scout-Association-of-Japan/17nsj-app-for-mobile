using Foundation;
using _17NSJ.Interfaces;
using Xamarin.Forms;
using _17NSJ.iOS.Platforms;

[assembly: Dependency(typeof(AssemblyService))]
namespace _17NSJ.iOS.Platforms
{
    public class AssemblyService: IAssemblyService
    {
        //アプリ名称を取得する
        public string GetPackageName()
        {
            string name = NSBundle.MainBundle.InfoDictionary["CFBundleDisplayName"].ToString();
            return name.ToString();
        }
        //アプリバージョン文字列を取得する
        public string GetVersionName()
        {
            string name = NSBundle.MainBundle.InfoDictionary["CFBundleShortVersionString"].ToString();
            return name.ToString();
        }

        //ビルドバージョン文字列を取得する
        public string GetBuildName()
        {
            string name = NSBundle.MainBundle.InfoDictionary["CFBundleVersion"].ToString();
            return name.ToString();
        }
    }
}
