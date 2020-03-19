using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Planungsboard.Presentation.UserControls
{
    /// <summary>
    /// Interaktionslogik für CardWarpPanel.xaml
    /// </summary>
    public partial class CardsWarpPanel : UserControl
    {
        public CardsWarpPanel()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty VisualQuarter1Property = DependencyProperty.Register(
            "VisualQuarter1", typeof(List<Planungsboard.Presentation.ViewModels.Visual>), typeof(CardsWarpPanel), new PropertyMetadata(default(List<Planungsboard.Presentation.ViewModels.Visual>)));

        public List<Planungsboard.Presentation.ViewModels.Visual> VisualQuarter1
        {
            get { return (List<Planungsboard.Presentation.ViewModels.Visual>) GetValue(VisualQuarter1Property); }
            set { SetValue(VisualQuarter1Property, value); }
        }

        public static readonly DependencyProperty VisualQuarter2Property = DependencyProperty.Register(
            "VisualQuarter2", typeof(List<Planungsboard.Presentation.ViewModels.Visual>), typeof(CardsWarpPanel), new PropertyMetadata(default(List<Planungsboard.Presentation.ViewModels.Visual>)));

        public List<Planungsboard.Presentation.ViewModels.Visual> VisualQuarter2
        {
            get { return (List<Planungsboard.Presentation.ViewModels.Visual>) GetValue(VisualQuarter2Property); }
            set { SetValue(VisualQuarter2Property, value); }
        }

        public static readonly DependencyProperty VisualQuarter3Property = DependencyProperty.Register(
            "VisualQuarter3", typeof(List<Planungsboard.Presentation.ViewModels.Visual>), typeof(CardsWarpPanel), new PropertyMetadata(default(List<Planungsboard.Presentation.ViewModels.Visual>)));

        public List<Planungsboard.Presentation.ViewModels.Visual> VisualQuarter3
        {
            get { return (List<Planungsboard.Presentation.ViewModels.Visual>) GetValue(VisualQuarter3Property); }
            set { SetValue(VisualQuarter3Property, value); }
        }

        public static readonly DependencyProperty VisualQuarter4Property = DependencyProperty.Register(
            "VisualQuarter4", typeof(List<Planungsboard.Presentation.ViewModels.Visual>), typeof(CardsWarpPanel), new PropertyMetadata(default(List<Planungsboard.Presentation.ViewModels.Visual>)));

        public List<Planungsboard.Presentation.ViewModels.Visual> VisualQuarter4
        {
            get { return (List<Planungsboard.Presentation.ViewModels.Visual>) GetValue(VisualQuarter4Property); }
            set { SetValue(VisualQuarter4Property, value); }
        }
    }
}
