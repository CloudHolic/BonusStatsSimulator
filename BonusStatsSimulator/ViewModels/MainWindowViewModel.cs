using System.Windows.Input;
using BonusStatsSimulator.Commands;
using BonusStatsSimulator.Models;

namespace BonusStatsSimulator.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public int Level
        {
            get { return Get(() => Level); }
            set { Set(() => Level, value); }
        }

        public string Type
        {
            get { return Get(() => Type); }
            set { Set(() => Type, value); }
        }

        public BonusStat Bonus
        {
            get { return Get(() => Bonus); }
            set { Set(() => Bonus, value); }
        }

        public MainWindowViewModel()
        {
            Level = 140;
            Type = "강력한 환생의 불꽃";
            Bonus = new BonusStat();
        }

        public ICommand ComboCommand
        {
            get
            {
                return Get(() => ComboCommand, new RelayCommand(() =>
                {
                    Bonus.Reset();
                }));
            }
        }

        public ICommand ChooseCommand
        {
            get
            {
                return Get(() => ChooseCommand, new RelayCommand(() =>
                {
                    Bonus.Reset();
                    Bonus = Utils.BonusStatProc.GetRandomOptions(Level, Type);
                }));
            }
        }

        public ICommand ResetCommand
        {
            get
            {
                return Get(() => ResetCommand, new RelayCommand(() =>
                {
                    Bonus.Reset();
                }));
            }
        }
    }
}