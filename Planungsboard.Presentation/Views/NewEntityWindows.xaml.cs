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

namespace Planungsboard.Presentation.Views
{
    /// <summary>
    /// Interaktionslogik für NewEntityWindows.xaml
    /// </summary>
    public partial class NewEntityWindows : Window
    {
        public NewEntityWindows()
        {
            InitializeComponent();
        }

   }

    public class NewGenericEntityWindows<T> : NewEntityWindows
    {
        public NewGenericEntityWindows()
        {
            
        }

        public T Instance { get; set; }
    }
}
