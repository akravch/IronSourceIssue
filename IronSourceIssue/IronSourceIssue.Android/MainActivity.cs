using Android.App;
using Android.Content.PM;
using Android.OS;
using Com.Ironsource.Mediationsdk;
using Com.Ironsource.Mediationsdk.Config;
using Com.Ironsource.Mediationsdk.Integration;
using Com.Ironsource.Mediationsdk.Utils;

namespace IronSourceIssue.Droid
{
    [Activity(Label = "IronSourceIssue", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            Xamarin.Forms.Forms.Init(this, savedInstanceState);

            ConfigFile.GetConfigFile().SetPluginData("Xamarin", IronSourceUtils.SDKVersion, "9.1.5.0");
            IronSource.SetRewardedVideoListener(new RewardedVideoListener());
            IronSource.SetUserId("892aa79c4cf54aa0a231ed3e23471a1b");
            IronSource.Init(this, "88fbfe65", IronSource.AD_UNIT.RewardedVideo);
            IronSource.ShouldTrackNetworkState(this, true);
            IntegrationHelper.ValidateIntegration(this);

            LoadApplication(new App(new RewardedVideoService()));
        }

        protected override void OnPause()
        {
            base.OnPause();
            IronSource.OnPause(this);
        }

        protected override void OnResume()
        {
            base.OnResume();
            IronSource.OnResume(this);
        }
    }
}