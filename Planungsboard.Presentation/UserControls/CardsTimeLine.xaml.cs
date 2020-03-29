using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Planungsboard.Presentation.UserControls
{
    /// <summary>
    ///     Interaktionslogik für CardsTimeLine.xaml
    /// </summary>
    public partial class CardsTimeLine : UserControl
    {
        public static readonly DependencyProperty CardsProperty = DependencyProperty.Register(
            "Cards", typeof(List<ViewModels.Card>), typeof(CardsTimeLine), new PropertyMetadata(default(List<ViewModels.Card>)));

        public static readonly DependencyProperty QuarterListProperty = DependencyProperty.Register(
            "QuarterList", typeof(List<string>), typeof(CardsTimeLine), new PropertyMetadata(default(List<string>)));

        public CardsTimeLine()
        {
            this.InitializeComponent();
        }


        public List<ViewModels.Card> Cards
        {
            get => (List<ViewModels.Card>) this.GetValue(CardsProperty);
            set => this.SetValue(CardsProperty, value);
        }

        public List<string> QuarterList
        {
            get => (List<string>) this.GetValue(QuarterListProperty);
            set => this.SetValue(QuarterListProperty, value);
        }
    }
}