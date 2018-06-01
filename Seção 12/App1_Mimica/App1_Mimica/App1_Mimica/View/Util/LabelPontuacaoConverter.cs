using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace App1_Mimica.View.Util
{
    class LabelPontuacaoConverter : IValueConverter
    {
        //View chamando ViewModel (Dado)
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if((byte)value == 0)
            {
                return " ";
            }
            else
            {
                return "Pontuação: " + value;
            }
            
        }

        //ViewModel chamando View
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
