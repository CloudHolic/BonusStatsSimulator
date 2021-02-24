using System.Windows.Input;
using BonusStatsSimulator.Commands;
using BonusStatsSimulator.Models;

namespace BonusStatsSimulator.ViewModels
{
    public class ContTrialSettingViewModel : DialogViewModelBase<ContTrialSettings>
    {
        public string Stat
        {
            get { return Get(() => Stat); }
            set { Set(() => Stat, value); }
        }

        public int Target
        {
            get { return Get(() => Target); }
            set { Set(() => Target, value); }
        }

        public bool ShowProgress
        {
            get { return Get(() => ShowProgress); }
            set { Set(() => ShowProgress, value); }
        }

        public ContTrialSettingViewModel()
        {
            Stat = "아무거나";
            Target = 100;
            ShowProgress = false;
        }

        public ICommand SaveCommand
        {
            get
            {
                return Get(() => SaveCommand, new RelayCommand(() =>
                {
                    Close(new ContTrialSettings
                    {
                        Stat = Stat,
                        Target = Target,
                        AllStatWeight = 10,
                        AtkWeight = 4,
                        ShowProgress = ShowProgress
                    });
                }, () => !string.IsNullOrWhiteSpace(Stat)));
            }
        }

        public ICommand CloseCommand
        {
            get
            {
                return Get(() => CloseCommand, new RelayCommand(() =>
                {
                    Close(null);
                }));
            }
        }
    }
}
