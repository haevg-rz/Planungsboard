﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using Planungsboard.Presentation.ViewModels;

namespace Planungsboard.Presentation
{
    public class CardsQuarterFilterForSingles : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var cards = values[0] as IEnumerable<Card>;
            var quarter = values[1] as string;

            return cards?.Where(c => c.AssignedQuarter != null && c.AssignedQuarter.Count == 1 && c.AssignedQuarter.Any(q => q == quarter)).ToList();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class CardsQuarterFilterForMultiples : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var cards = values[0] as IEnumerable<Card>;
            var quarters = values[1] as IEnumerable<string>;

            var r = cards?.Where(c => c.AssignedQuarter != null
                                      && c.AssignedQuarter.Count > 1
                                      && c.AssignedQuarter.Intersect(quarters).Any()
            ).ToList();
            return r;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public List<Card> Convert(IEnumerable<Card> cards, IEnumerable<string> quarters)
        {
            return this.Convert(new object[] {cards, quarters}, null, null, null) as List<Card>;
        }
    }
}