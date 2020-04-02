using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using Planungsboard.Presentation.ViewModels;

namespace Planungsboard.Presentation.Message
{
    public class DropMessage
    {
        public Card Card { get; set; }
        public ItemsControl DropTarget { get; set; }
        public int DisplayQuarterIndex { get; set; }
        public Team Team { get; set; }
    }
}
