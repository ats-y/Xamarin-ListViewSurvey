using System;
using System.Globalization;
using Xamarin.Forms;

namespace CreateNew.Converters
{
    /// <summary>
    /// ItemTappedEventArgsオブジェクトをItemTappedEventArgs.Itemに変更するConverterクラス。
    /// </summary>
    public class ItemTappedEventArgsConverter : IValueConverter
    {
        public ItemTappedEventArgsConverter()
        {
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // 
            var itemTappedEventArgs = value as ItemTappedEventArgs;
            if (itemTappedEventArgs == null)
            {
                throw new ArgumentException("Expected value to be of type ItemTappedEventArgs", nameof(value));
            }
            return itemTappedEventArgs.Item;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
