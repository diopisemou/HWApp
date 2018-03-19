using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;

namespace HWApp
{
    class SliderConverter :  IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //double result = (bool)value ? 100 : 0;
            //return result;
            bool result = (double)(value) - 100 >= 0;
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //double result = (bool)value ? 100 : 0;
            //return result;   
            bool result = (double)(value) - 100 >= 0;
            return result;
        }
    }
}
