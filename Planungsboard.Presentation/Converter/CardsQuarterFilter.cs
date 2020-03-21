using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using Planungsboard.Presentation.ViewModels;

namespace Planungsboard.Presentation
{
    public class CardsQuarterFilter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var cards = values[0] as IEnumerable<Card>;
            var quarter = values[1] as string;

            return cards?.Where(c => c.AssignedQuarter!= null && c.AssignedQuarter.Any(q => q == quarter)).ToList();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}