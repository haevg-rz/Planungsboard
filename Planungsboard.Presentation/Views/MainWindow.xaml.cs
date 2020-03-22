using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Planungsboard.Presentation.ViewModels;

namespace Planungsboard.Presentation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FrameworkElement_OnSizeChanged2(object sender, SizeChangedEventArgs e)
        {
            var grid = sender as Grid;
            var firstColumn = grid.ColumnDefinitions.FirstOrDefault();
            ((MainViewModel) this.DataContext).TeamLabelWidth = firstColumn.ActualWidth;
        }
    }
}