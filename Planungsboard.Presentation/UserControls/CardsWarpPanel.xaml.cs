using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using GalaSoft.MvvmLight.Messaging;
using Planungsboard.Presentation.Message;
using Planungsboard.Presentation.ViewModels;

namespace Planungsboard.Presentation.UserControls
{
    /// <summary>
    ///     Interaktionslogik für CardWarpPanel.xaml
    /// </summary>
    public partial class CardsWarpPanel : UserControl
    {
        public static readonly DependencyProperty Quarter1CardsProperty = DependencyProperty.Register(
            "Quarter1Cards", typeof(List<ViewModels.Card>), typeof(CardsWarpPanel), new PropertyMetadata(default(List<ViewModels.Card>)));

        public static readonly DependencyProperty Quarter2CardsProperty = DependencyProperty.Register(
            "Quarter2Cards", typeof(List<ViewModels.Card>), typeof(CardsWarpPanel), new PropertyMetadata(default(List<ViewModels.Card>)));

        public static readonly DependencyProperty Quarter3CardsProperty = DependencyProperty.Register(
            "Quarter3Cards", typeof(List<ViewModels.Card>), typeof(CardsWarpPanel), new PropertyMetadata(default(List<ViewModels.Card>)));

        public static readonly DependencyProperty Quarter4CardsProperty = DependencyProperty.Register(
            "Quarter4Cards", typeof(List<ViewModels.Card>), typeof(CardsWarpPanel), new PropertyMetadata(default(List<ViewModels.Card>)));

        public CardsWarpPanel()
        {
            this.InitializeComponent();
        }

        public List<ViewModels.Card> Quarter1Cards
        {
            get => (List<ViewModels.Card>) this.GetValue(Quarter1CardsProperty);
            set => this.SetValue(Quarter1CardsProperty, value);
        }

        public List<ViewModels.Card> Quarter2Cards
        {
            get => (List<ViewModels.Card>) this.GetValue(Quarter2CardsProperty);
            set => this.SetValue(Quarter2CardsProperty, value);
        }

        public List<ViewModels.Card> Quarter3Cards
        {
            get => (List<ViewModels.Card>) this.GetValue(Quarter3CardsProperty);
            set => this.SetValue(Quarter3CardsProperty, value);
        }

        public List<ViewModels.Card> Quarter4Cards
        {
            get => (List<ViewModels.Card>) this.GetValue(Quarter4CardsProperty);
            set => this.SetValue(Quarter4CardsProperty, value);
        }

        public static readonly DependencyProperty TeamProperty = DependencyProperty.Register(
            "Team", typeof(Team), typeof(CardsWarpPanel), new PropertyMetadata(default(Team)));

        public Team Team
        {
            get { return (Team) GetValue(TeamProperty); }
            set { SetValue(TeamProperty, value); }
        }

        private void Quarter1Cards_OnDrop(object sender, DragEventArgs e)
        {
            var displayQuarterIndex = 0;

            this.SendDropMessage(sender, e, displayQuarterIndex);
        }

        private void Quarter2Cards_OnDrop(object sender, DragEventArgs e)
        {
            var displayQuarterIndex = 1;

            this.SendDropMessage(sender, e, displayQuarterIndex);
        }

        private void Quarter3Cards_OnDrop(object sender, DragEventArgs e)
        {
            var displayQuarterIndex = 2;

            this.SendDropMessage(sender, e, displayQuarterIndex);
        }

        private void Quarter4Cards_OnDrop(object sender, DragEventArgs e)
        {
            var displayQuarterIndex = 3;

            this.SendDropMessage(sender, e, displayQuarterIndex);
        }

        private void SendDropMessage(object sender, DragEventArgs e, int displayQuarterIndex)
        {
            var card = e.Data.GetData("Object") as ViewModels.Card;
            var senderControl = sender as ItemsControl;

            Messenger.Default.Send<DropMessage>(new DropMessage()
            {
                Card = card,
                DropTarget = senderControl,
                Team = this.Team,
                DisplayQuarterIndex = displayQuarterIndex,
            });
        }
    }
}