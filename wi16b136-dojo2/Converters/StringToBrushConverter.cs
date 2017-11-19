using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace wi16b136_dojo2.Converters
{
    class StringToBrushConverter : IValueConverter
    {
        public object Convert (object value, Type targetType, object parameter, CultureInfo culture)
        {
            string temp = (string)value;
            if (temp.Equals("Enabled")) {
                return new SolidColorBrush(Colors.Green);
            } else {
                return new SolidColorBrush(Colors.Red);

            }
        }

        public object ConvertBack (object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
