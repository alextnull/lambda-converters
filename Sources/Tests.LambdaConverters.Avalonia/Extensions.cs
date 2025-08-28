using System;
using System.Collections.Generic;
using System.Globalization;
using Avalonia.Data.Converters;
using LambdaConverters;

namespace Tests.LambdaConverters.Avalonia
{
    public static class Extensions
    {
        public static IList<object?> ConvertBack(this IMultiValueConverter converter, object? value, IList<Type> targetTypes, object? parameter, CultureInfo culture)
        {
            return ((IExtendedMultiValueConverter)converter).ConvertBack(value, targetTypes, parameter, culture);
        }
    }
}
