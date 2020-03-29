using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Planungsboard.Presentation.UserControls
{
    /// <summary>
    /// Interaktionslogik für CardsTimeLine.xaml
    /// </summary>
    public partial class CardsTimeLine : UserControl
    {
        public CardsTimeLine()
        {
            this.InitializeComponent();
        }

        public static readonly DependencyProperty CardsProperty = DependencyProperty.Register(
            "Cards", typeof(List<Planungsboard.Presentation.ViewModels.Card>), typeof(CardsTimeLine), new PropertyMetadata(default(List<Planungsboard.Presentation.ViewModels.Card>)));


        public List<Planungsboard.Presentation.ViewModels.Card> Cards
        {
            get { return (List<Planungsboard.Presentation.ViewModels.Card>) this.GetValue(CardsProperty); }
            set { this.SetValue(CardsProperty, value); }
        }

        public static readonly DependencyProperty QuarterListProperty = DependencyProperty.Register(
            "QuarterList", typeof(List<string>), typeof(CardsTimeLine), new PropertyMetadata(default(List<string>)));

        public List<string> QuarterList
        {
            get { return (List<string>) this.GetValue(QuarterListProperty); }
            set { this.SetValue(QuarterListProperty, value); }
        }
    }
}