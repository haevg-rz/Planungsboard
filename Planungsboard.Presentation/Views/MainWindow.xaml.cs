using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Planungsboard.Presentation.ViewModels;

namespace Planungsboard.Presentation
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void FrameworkElement_OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            var grid = sender as Grid;
            var firstColumn = grid.ColumnDefinitions.FirstOrDefault();
            ((MainViewModel) this.DataContext).TeamLabelWidth = firstColumn.ActualWidth;
        }
    }
}