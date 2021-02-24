using System.Text.RegularExpressions;
using System.Windows.Input;
using BonusStatsSimulator.ViewModels;

namespace BonusStatsSimulator.Contents
{
    /// <summary>
    /// ContTrialSettingView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ContTrialSettingView
    {
        public ContTrialSettingView()
        {
            InitializeComponent();
        }

        private void TargetTextBox_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
