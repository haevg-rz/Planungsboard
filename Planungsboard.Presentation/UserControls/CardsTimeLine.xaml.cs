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

namespace Planungsboard.Presentation
{
    /// <summary>
    /// Interaktionslogik für CardsTimeLine.xaml
    /// </summary>
    public partial class CardsTimeLine : UserControl
    {
        public CardsTimeLine()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty VisualsProperty = DependencyProperty.Register(
            "Visuals", typeof(List<Planungsboard.Presentation.ViewModels.Visual>), typeof(CardsTimeLine), new PropertyMetadata(default(List<Planungsboard.Presentation.ViewModels.Visual>), PropertyChangedCallback));

        private static void PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        public List<Planungsboard.Presentation.ViewModels.Visual> Visuals
        {
            get { return (List<Planungsboard.Presentation.ViewModels.Visual>) GetValue(VisualsProperty); }
            set { SetValue(VisualsProperty, value); }
        }
    }
}