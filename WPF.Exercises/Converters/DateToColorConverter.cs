using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace WPF.Exercises.Converters
{
    public class DateToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var date = value as DateTime?;
            if (!date.HasValue)
            {
                return new SolidColorBrush(Colors.Black);
            }

            var diff = (DateTime.Now - date.Value).Days;
            if (diff > 60)
            {
                return new SolidColorBrush(Colors.Red);
            }

            if (diff > 30)
            {
                return new SolidColorBrush(Colors.Brown);
            }

            return new SolidColorBrush(Colors.Green);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
