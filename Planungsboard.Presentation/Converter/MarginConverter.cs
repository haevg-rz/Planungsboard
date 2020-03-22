using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using Planungsboard.Presentation.ViewModels;

namespace Planungsboard.Presentation
{
    public class MarginConverter : IMultiValueConverter
    {
        public Thickness Convert(double actualWidth, Card card, List<string> quarters)
        {
            return (Thickness) Convert(new object[]
            {
                actualWidth,
                card,
                quarters
            }, null, null, null);
        }

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                var actualWidth = (double) values[0];
                var viewModel = (Card) values[1];
                var quarters = values[2] as List<string>;

                var sectionWidth = actualWidth / quarters.Count;

                var intersectQuarters = quarters.Intersect(viewModel.AssignedQuarter).ToList();

                var leftIndex = quarters.IndexOf(intersectQuarters.OrderBy(s => s).First());
                var rightIndex = quarters.IndexOf(intersectQuarters.OrderBy(s => s).Last());

                var left = sectionWidth * leftIndex;
                var right = sectionWidth * (quarters.Count - (rightIndex + 1));
                return new Thickness(left, 2, right, 0);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                return new Thickness(50, 5, 50, 5);
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}