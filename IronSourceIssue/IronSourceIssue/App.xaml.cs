using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace IronSourceIssue
{
    public partial class App : Application
    {
        public App(IRewardedVideoService rewardedVideoService)
        {
            InitializeComponent();

            MainPage = new MainPage(rewardedVideoService);
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
