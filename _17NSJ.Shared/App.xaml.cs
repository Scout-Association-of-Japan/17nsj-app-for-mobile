using Xamarin.Forms;
using _17NSJ.Views;

namespace _17NSJ
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabBaseView();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
