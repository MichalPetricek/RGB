using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGB.ViewModels;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace RGB.ViewModels.Converters
{
    class IntToHex : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is SolidColorBrush && targetType == typeof(string))
            {
                SolidColorBrush scb = value as SolidColorBrush;
                string r = ((int)scb.Color.R).ToString("X");
                string g = ((int)scb.Color.G).ToString("X");
                string b = ((int)scb.Color.B).ToString("X");
                return "#" + r + g + b;
            }
            return value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
