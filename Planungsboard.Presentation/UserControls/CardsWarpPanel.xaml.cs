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

        public static readonly DependencyProperty Quarter1CardsProperty = DependencyProperty.Register(
            "Quarter1Cards", typeof(List<Planungsboard.Presentation.ViewModels.Card>), typeof(CardsWarpPanel), new PropertyMetadata(default(List<Planungsboard.Presentation.ViewModels.Card>)));

        public List<Planungsboard.Presentation.ViewModels.Card> Quarter1Cards
        {
            get { return (List<Planungsboard.Presentation.ViewModels.Card>) GetValue(Quarter1CardsProperty); }
            set { SetValue(Quarter1CardsProperty, value); }
        }

        public static readonly DependencyProperty Quarter2CardsProperty = DependencyProperty.Register(
            "Quarter2Cards", typeof(List<Planungsboard.Presentation.ViewModels.Card>), typeof(CardsWarpPanel), new PropertyMetadata(default(List<Planungsboard.Presentation.ViewModels.Card>)));

        public List<Planungsboard.Presentation.ViewModels.Card> Quarter2Cards
        {
            get { return (List<Planungsboard.Presentation.ViewModels.Card>) GetValue(Quarter2CardsProperty); }
            set { SetValue(Quarter2CardsProperty, value); }
        }

        public static readonly DependencyProperty Quarter3CardsProperty = DependencyProperty.Register(
            "Quarter3Cards", typeof(List<Planungsboard.Presentation.ViewModels.Card>), typeof(CardsWarpPanel), new PropertyMetadata(default(List<Planungsboard.Presentation.ViewModels.Card>)));

        public List<Planungsboard.Presentation.ViewModels.Card> Quarter3Cards
        {
            get { return (List<Planungsboard.Presentation.ViewModels.Card>) GetValue(Quarter3CardsProperty); }
            set { SetValue(Quarter3CardsProperty, value); }
        }

        public static readonly DependencyProperty Quarter4CardsProperty = DependencyProperty.Register(
            "Quarter4Cards", typeof(List<Planungsboard.Presentation.ViewModels.Card>), typeof(CardsWarpPanel), new PropertyMetadata(default(List<Planungsboard.Presentation.ViewModels.Card>)));

        public List<Planungsboard.Presentation.ViewModels.Card> Quarter4Cards
        {
            get { return (List<Planungsboard.Presentation.ViewModels.Card>) GetValue(Quarter4CardsProperty); }
            set { SetValue(Quarter4CardsProperty, value); }
        }
    }
}