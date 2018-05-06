using System;
using System.Collections.Generic;
using System.Reflection;
using Xamarin.Forms;

namespace _17NSJ.Views
{
    public partial class LicenseDetailView : ContentPage
    {
        public LicenseDetailView(string licenseFileName)
        {
            InitializeComponent();

            var assembly = typeof(LicenseDetailView).GetTypeInfo().Assembly;
            System.IO.Stream stream = assembly.GetManifestResourceStream(licenseFileName);

            using (var reader = new System.IO.StreamReader(stream))
            {
                var license = reader.ReadToEnd();
                this.licenseArticle.Text = license;
            }
        }
    }
}
