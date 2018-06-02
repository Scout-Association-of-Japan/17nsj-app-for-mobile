using System;
using Xamarin.Forms;

namespace _17NSJ.Converters
{
    public class InverseBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var result = value as bool?;

            if (result == null)
            {
                return false;
            }

            return !((bool)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var result = value as bool?;

            if (result == null)
            {
                return false;
            }

            return !((bool)value);
        }
    }
}
