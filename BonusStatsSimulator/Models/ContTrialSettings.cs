namespace BonusStatsSimulator.Models
{
    public class ContTrialSettings
    {
        public string Stat { get; set; }

        public int Target { get; set; }

        public int AllStatWeight { get; set; }

        public int AtkWeight { get; set; }

        public bool ShowProgress { get; set; }

        public ContTrialSettings()
        {
            Stat = "아무거나";
            Target = 0;
            AllStatWeight = 10;
            AtkWeight = 4;
            ShowProgress = false;
        }

        public ContTrialSettings(ContTrialSettings prevContTrialSettings)
        {
            Stat = prevContTrialSettings.Stat;
            Target = prevContTrialSettings.Target;
            AllStatWeight = prevContTrialSettings.AllStatWeight;
            AtkWeight = prevContTrialSettings.AtkWeight;
            ShowProgress = prevContTrialSettings.ShowProgress;
        }
    }
}
