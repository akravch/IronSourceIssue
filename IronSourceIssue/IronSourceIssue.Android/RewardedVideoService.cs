using Com.Ironsource.Mediationsdk;

namespace IronSourceIssue.Droid
{
    internal class RewardedVideoService : IRewardedVideoService
    {
        public string ShowVideo()
        {
            if (IronSource.IsRewardedVideoAvailable)
            {
                IronSource.ShowRewardedVideo("DefaultRewardedVideo");
                return "Rewarded video shown";
            }

            return "Rewarded video is unavailable";
        }
    }
}