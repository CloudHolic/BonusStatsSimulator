using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace BonusStatsSimulator.Converters
{
    [ValueConversion(typeof(int), typeof(SolidColorBrush))]
    public class TextToForegroundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var flag = value is int i && i > 0;
            return new SolidColorBrush(flag ? Colors.Red : Colors.Green);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}