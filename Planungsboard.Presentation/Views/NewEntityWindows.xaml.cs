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
using Planungsboard.Presentation.ViewModels;

namespace Planungsboard.Presentation.Views
{
    /// <summary>
    /// Interaktionslogik für NewEntityWindows.xaml
    /// </summary>
    public partial class NewEntityWindows : Window
    {
        public NewEntityWindows()
        {
            this.InitializeComponent();
        }

        public object Result
        {
            get => new ViewModelLocator().NewEntityWindowsViewModel.Result;
        }

        public object Instance
        {
            get => new ViewModelLocator().NewEntityWindowsViewModel.Instance;
            set => new ViewModelLocator().NewEntityWindowsViewModel.Instance = value;
        }

        private void CancelButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

    public class NewGenericEntityWindows<T> : NewEntityWindows where T : class, new()
    {
        public NewGenericEntityWindows()
        {
            this.Instance = new T();
        }

        public new T Result => base.Result as T;
    }
}