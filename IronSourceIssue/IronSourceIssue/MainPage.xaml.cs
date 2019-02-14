using System;
using Xamarin.Forms;

namespace IronSourceIssue
{
    public partial class MainPage : ContentPage
    {
        private readonly IRewardedVideoService _rewardedVideoService;

        public MainPage(IRewardedVideoService rewardedVideoService)
        {
            _rewardedVideoService = rewardedVideoService;
            InitializeComponent();
        }

        private void OnShowVideoClicked(object sender, EventArgs e)
        {
            Label.Text = _rewardedVideoService.ShowVideo();
        }
    }
}
