using System;
using System.CodeDom.Compiler;
using System.Net.Mime;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using BonusStatsSimulator.Commands;
using BonusStatsSimulator.Contents;
using BonusStatsSimulator.Models;
using BonusStatsSimulator.Utils;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

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

        private readonly ICustomDialogManager _dialogManager;
        private bool _isWorking;

        public MainWindowViewModel()
        {
            Level = 140;
            Type = "강력한 환생의 불꽃";
            Bonus = new BonusStat();
            _isWorking = false;

            _dialogManager = new CustomDialogManager(new MetroDialogSettings
            {
                AnimateHide = false,
                AnimateShow = false
            });
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

        public ICommand TrialCommand
        {
            get
            {
                return Get(() => TrialCommand, new RelayCommand(() =>
                {
                    Bonus.Reset();
                    Bonus = BonusStatProc.GetRandomOptions(Level, Type);
                }, () => !_isWorking));
            }
        }

        public ICommand ContCommand
        {
            get
            {
                return Get(() => ContCommand, new RelayCommand(async () =>
                {
                    var view = new ContTrialSettingView();
                    var setting = await _dialogManager.ShowDialogAsync<ContTrialSettings>(view);
                    
                    if(setting != null)
                    {
                        BonusStat temp;
                        _isWorking = true;
                        var weighted = 0;
                        var tryCount = 0;

                        for (;;)
                        {
                            tryCount++;
                            temp = BonusStatProc.GetRandomOptions(Level, Type);
                            
                            switch (setting.Stat)
                            {
                                case "STR":
                                    weighted = temp.Str + temp.All * setting.AllStatWeight + temp.Atk * setting.AtkWeight;
                                    break;
                                case "DEX":
                                    weighted = temp.Dex + temp.All * setting.AllStatWeight + temp.Atk * setting.AtkWeight;
                                    break;
                                case "INT":
                                    weighted = temp.Int + temp.All * setting.AllStatWeight + temp.Mtk * setting.AtkWeight;
                                    break;
                                case "LUK":
                                    weighted = temp.Luk + temp.All * setting.AllStatWeight + temp.Atk * setting.AtkWeight;
                                    break;
                                case "아무거나":
                                    weighted = Math.Max(Math.Max(temp.Str, Math.Max(temp.Dex, temp.Luk)) + temp.All * setting.AllStatWeight + temp.Atk * setting.AtkWeight,
                                        temp.Int + temp.All * setting.AllStatWeight + temp.Mtk * setting.AtkWeight);
                                    break;
                            }

                            /*
                            if (setting.ShowProgress)
                            {
                                var tempResult = temp;
                                Application.Current.Invoke(new Action(() =>
                                {
                                    Bonus = new BonusStat(tempResult);
                                }));

                                Thread.Sleep(100);
                            }*/

                            if (weighted >= setting.Target)
                                break;
                        }

                        Bonus = new BonusStat(temp);

                        await _dialogManager.ShowMessageBox("연속 뽑기", $"{tryCount}회 걸렸습니다.");
                        _isWorking = false;
                    }
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