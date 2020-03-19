using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Planungsboard.Presentation.ViewModels;

namespace Planungsboard.Presentation
{
    public class MarginConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var actualWidth = (double)values[0];
            var sections = (int)values[1];
            var viewModel = (Visual)values[2];
            var sectionWidth = actualWidth / sections;

            return new Thickness(sectionWidth*viewModel.LeftMargin,2,sectionWidth*viewModel.RightMargin,0);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}