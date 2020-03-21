﻿using System.Collections.Generic;
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
            InitializeComponent();
        }

        public static readonly DependencyProperty CardsProperty = DependencyProperty.Register(
            "Cards", typeof(List<Planungsboard.Presentation.ViewModels.Card>), typeof(CardsTimeLine), new PropertyMetadata(default(List<Planungsboard.Presentation.ViewModels.Card>)));


        public List<Planungsboard.Presentation.ViewModels.Card> Cards
        {
            get { return (List<Planungsboard.Presentation.ViewModels.Card>) GetValue(CardsProperty); }
            set { SetValue(CardsProperty, value); }
        }
    }
}