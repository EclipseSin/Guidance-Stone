﻿using GuidanceStone;
using System;
using System.Windows.Controls;
using System.Windows.Data;

namespace GuidanceStoneViewer.Converters
{
    public class ItemToIndexConverter : IMultiValueConverter
    {
        public object Convert(object[] value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var itemCollection = value[0] as ItemCollection;
            var item = value[1] as Instance;

            return itemCollection.IndexOf(item);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
