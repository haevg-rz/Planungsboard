using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Planungsboard.Presentation.UserControls
{
    /// <summary>
    ///     Interaktionslogik für Card.xaml
    /// </summary>
    public partial class Card : UserControl
    {
        public static readonly DependencyProperty ItemProperty = DependencyProperty.Register(
            "Item", typeof(ViewModels.Card), typeof(Card), new PropertyMetadata(default(ViewModels.Card)));

        public Card()
        {
            this.InitializeComponent();
        }

        public ViewModels.Card Item
        {
            get => (ViewModels.Card) this.GetValue(ItemProperty);
            set => this.SetValue(ItemProperty, value);
        }

        private void Card_OnMouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DataObject data = new DataObject();
                data.SetData("Object", this.Item);

                DragDrop.DoDragDrop(this, data, DragDropEffects.Copy | DragDropEffects.Move);
            }
        }
    }
}