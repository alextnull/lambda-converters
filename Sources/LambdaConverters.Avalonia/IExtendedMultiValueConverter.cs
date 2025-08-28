using System;
using System.Collections.Generic;
using System.Globalization;
using Avalonia;
using Avalonia.Data.Converters;

namespace LambdaConverters
{
    /// <summary>
    /// Converts multi-binding inputs to a final value.
    /// </summary>
    public interface IExtendedMultiValueConverter : IMultiValueConverter
    {
        /// <summary>
        /// Converts a binding target value to the source binding values.
        /// </summary>
        /// <returns>An array of values that have been converted from the target value back to the source values.</returns>
        /// <param name="value">The value that the binding target produces.</param>
        /// <param name="targetTypes">The array of types to convert to. The array length indicates the number and types of values that are suggested for the method to return.</param>
        /// <param name="parameter">The converter parameter to use.</param>
        /// <param name="culture">The culture to use in the converter.</param>
        IList<object?> ConvertBack(object? value, IList<Type> targetTypes, object? parameter, CultureInfo culture);
    }
}
