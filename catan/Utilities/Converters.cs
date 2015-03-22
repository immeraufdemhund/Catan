using Catan.Models;
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace catan.Utilities
{
    internal class ResourceTypeToSolidBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((ResourceType)value)
            {
                case ResourceType.Desert:
                    return Brushes.SandyBrown;
                case ResourceType.Hills:
                    return Brushes.DarkRed;
                case ResourceType.Pastures:
                    return Brushes.LightGreen;
                case ResourceType.Mountains:
                    return Brushes.DarkSlateGray;
                case ResourceType.Fields:
                    return Brushes.Wheat;
                case ResourceType.Forests:
                    return Brushes.ForestGreen;
                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
