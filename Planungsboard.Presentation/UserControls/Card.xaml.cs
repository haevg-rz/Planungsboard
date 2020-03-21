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
    /// Interaktionslogik für Card.xaml
    /// </summary>
    public partial class Card : UserControl
    {
        public Card()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty ItemProperty = DependencyProperty.Register(
            "Item", typeof(ViewModels.Card), typeof(Card), new PropertyMetadata(default(ViewModels.Card)));

        public ViewModels.Card Item
        {
            get { return (ViewModels.Card) GetValue(ItemProperty); }
            set { SetValue(ItemProperty, value); }
        }
    }
}