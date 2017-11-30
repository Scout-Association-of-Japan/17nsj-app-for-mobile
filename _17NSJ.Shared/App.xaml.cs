using Xamarin.Forms;
using _17NSJ.Views;
using _17NSJ.Services;
using _17NSJ.Interfaces;

namespace _17NSJ
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            InitialzeTokenAsync();

            MainPage = new NavigationPage(new TopView())
            {
                BarBackgroundColor = new Color(0.00, 0.44, 0.74),
                BarTextColor = Color.White
            };
        }

        public async void InitialzeTokenAsync()
        {
            Token = await new AuthService().GetToken();
        }

        //使うときは(Application.Current as App).Token
        public string Token { get; set; }

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
