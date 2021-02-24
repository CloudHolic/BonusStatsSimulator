using System.ComponentModel;

namespace BonusStatsSimulator.Models
{
    public class BonusStat : INotifyPropertyChanged
    {
        #region Str
        private int _str;
        public int Str
        {
            get => _str;
            set
            {
                _str = value;
                OnPropertyChanged(nameof(Str));
            }
        }
        #endregion

        #region Dex
        private int _dex;
        public int Dex
        {
            get => _dex;
            set
            {
                _dex = value;
                OnPropertyChanged(nameof(Dex));
            }
        }
        #endregion

        #region Int
        private int _int;
        public int Int
        {
            get => _int;
            set
            {
                _int = value;
                OnPropertyChanged(nameof(Int));
            }
        }
        #endregion

        #region Luk
        private int _luk;
        public int Luk
        {
            get => _luk;
            set
            {
                _luk = value;
                OnPropertyChanged(nameof(Luk));
            }
        }
        #endregion

        #region Hp
        private int _hp;
        public int Hp
        {
            get => _hp;
            set
            {
                _hp = value;
                OnPropertyChanged(nameof(Hp));
            }
        }
        #endregion

        #region Mp
        private int _mp;
        public int Mp
        {
            get => _mp;
            set
            {
                _mp = value;
                OnPropertyChanged(nameof(Mp));
            }
        }
        #endregion

        #region All
        private int _all;
        public int All
        {
            get => _all;
            set
            {
                _all = value;
                OnPropertyChanged(nameof(All));
            }
        }
        #endregion

        #region Atk
        private int _atk;
        public int Atk
        {
            get => _atk;
            set
            {
                _atk = value;
                OnPropertyChanged(nameof(Atk));
            }
        }
        #endregion

        #region Mtk
        private int _mtk;
        public int Mtk
        {
            get => _mtk;
            set
            {
                _mtk = value;
                OnPropertyChanged(nameof(Mtk));
            }
        }
        #endregion

        #region Spd
        private int _spd;
        public int Spd
        {
            get => _spd;
            set
            {
                _spd = value;
                OnPropertyChanged(nameof(Spd));
            }
        }
        #endregion

        #region Jmp
        private int _jmp;
        public int Jmp
        {
            get => _jmp;
            set
            {
                _jmp = value;
                OnPropertyChanged(nameof(Jmp));
            }
        }
        #endregion

        #region Mtk
        private int _def;
        public int Def
        {
            get => _def;
            set
            {
                _def = value;
                OnPropertyChanged(nameof(Def));
            }
        }
        #endregion

        #region ReqLev
        private int _reqLev;
        public int ReqLev
        {
            get => _reqLev;
            set
            {
                _reqLev = value;
                OnPropertyChanged(nameof(ReqLev));
            }
        }
        #endregion

        public BonusStat()
        {
            Reset();
        }

        public BonusStat(BonusStat prevBonus)
        {
            Str = prevBonus.Str;
            Dex = prevBonus.Dex;
            Int = prevBonus.Int;
            Luk = prevBonus.Luk;
            Hp = prevBonus.Hp;
            Mp = prevBonus.Mp;
            All = prevBonus.All;
            Atk = prevBonus.Atk;
            Mtk = prevBonus.Mtk;
            Spd = prevBonus.Spd;
            Jmp = prevBonus.Jmp;
            Def = prevBonus.Def;
            ReqLev = prevBonus.ReqLev;
        }

        public void Reset()
        {
            Str = Dex = Int = Luk = Hp = Mp = All = Atk = Mtk = Spd = Jmp = Def = ReqLev = 0;
        }

        public void AddStat(int index, int value)
        {
            switch (index)
            {
                case 0:
                    Str += value;
                    break;
                case 1:
                    Dex += value;
                    break;
                case 2:
                    Int += value;
                    break;
                case 3:
                    Luk += value;
                    break;
                case 4:
                    Str += value;
                    Dex += value;
                    break;
                case 5:
                    Str += value;
                    Int += value;
                    break;
                case 6:
                    Str += value;
                    Luk += value;
                    break;
                case 7:
                    Dex += value;
                    Int += value;
                    break;
                case 8:
                    Dex += value;
                    Luk += value;
                    break;
                case 9:
                    Int += value;
                    Luk += value;
                    break;
                case 10:
                    Hp += value;
                    break;
                case 11:
                    Mp += value;
                    break;
                case 12:
                    All += value;
                    break;
                case 13:
                    Atk += value;
                    break;
                case 14:
                    Mtk += value;
                    break;
                case 15:
                    Spd += value;
                    break;
                case 16:
                    Jmp += value;
                    break;
                case 17:
                    Def += value;
                    break;
                case 18:
                    ReqLev += value;
                    break;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
