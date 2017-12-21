using ICT13580034EndB.Helpers;
using Xamarin.Forms;

namespace ICT13580034EndB
{
    public partial class App : Application
    {
		public static DbHelper DbHelper { get; set; }

		public App()
		{
			InitializeComponent();
		}

		public App(string dbPath)
		{
			InitializeComponent();

			DbHelper = new DbHelper(dbPath);

            MainPage = new NavigationPage(new ICT13580034EndBPage());
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
