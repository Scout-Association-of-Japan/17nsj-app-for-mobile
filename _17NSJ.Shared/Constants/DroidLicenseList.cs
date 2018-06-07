using System;
using System.Collections.ObjectModel;
using _17NSJ.Models;

namespace _17NSJ.Constants
{
    public static class iOSLicenseList
    {
        static iOSLicenseList()
        {
            ObservableCollection<LicenseModel> list = new ObservableCollection<LicenseModel>();
            list.Add(new LicenseModel() { LibraryName = "AiForms.Layouts", LicenseFileName = "_17NSJ.Licenses.AiForms.Layouts.txt" });
            list.Add(new LicenseModel() { LibraryName = "CarouselView.FormsPlugin", LicenseFileName = "_17NSJ.Licenses.CarouselView.FormsPlugin.txt" });
            list.Add(new LicenseModel() { LibraryName = "Com.Airbnb.iOS.Lottie", LicenseFileName = "_17NSJ.Licenses.Com.Airbnb.iOS.Lottie.txt" });
            list.Add(new LicenseModel() { LibraryName = "Com.Airbnb.Xamarin.Forms.Lottie", LicenseFileName = "_17NSJ.Licenses.Com.Airbnb.Xamarin.Forms.Lottie.txt" });
            list.Add(new LicenseModel() { LibraryName = "Microsoft.AppCenter", LicenseFileName = "_17NSJ.Licenses.Microsoft.AppCenter.txt" });
            list.Add(new LicenseModel() { LibraryName = "Microsoft.AppCenter.Analytics", LicenseFileName = "_17NSJ.Licenses.Microsoft.AppCenter.txt" });
            list.Add(new LicenseModel() { LibraryName = "Microsoft.AppCenter.Crashes", LicenseFileName = "_17NSJ.Licenses.Microsoft.AppCenter.txt" });
            list.Add(new LicenseModel() { LibraryName = "Microsoft.AppCenter.Push", LicenseFileName = "_17NSJ.Licenses.Microsoft.AppCenter.txt" });
            list.Add(new LicenseModel() { LibraryName = "Newtonsoft.Json", LicenseFileName = "_17NSJ.Licenses.Newtonsoft.Json.txt" });
            list.Add(new LicenseModel() { LibraryName = "Plugin.Permissions", LicenseFileName = "_17NSJ.Licenses.Plugin.Permissions.txt" });
            list.Add(new LicenseModel() { LibraryName = "Xam.Plugin.Geolocator", LicenseFileName = "_17NSJ.Licenses.Xam.Plugin.Geolocator.txt" });
            list.Add(new LicenseModel() { LibraryName = "Xamarin.Build.Download", LicenseFileName = "_17NSJ.Licenses.Xamarin.Build.Download.txt" });
            list.Add(new LicenseModel() { LibraryName = "Xamarin.Forms", LicenseFileName = "_17NSJ.Licenses.Xamarin.Forms.txt" });
            list.Add(new LicenseModel() { LibraryName = "Xamarin.Forms.GoogleMaps", LicenseFileName = "_17NSJ.Licenses.Xamarin.Forms.GoogleMaps.txt" });
            list.Add(new LicenseModel() { LibraryName = "Xamarin.Google.iOS.Maps", LicenseFileName = "_17NSJ.Licenses.Xamarin.Google.iOS.Maps.txt" });
            list.Add(new LicenseModel() { LibraryName = "XamForms.Controls.Calendar", LicenseFileName = "_17NSJ.Licenses.XamForms.Controls.Calendar.txt" });

            List = list;

        }

        public static readonly ObservableCollection<LicenseModel> List;

    }
}
