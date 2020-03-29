using System.Windows;
using Planungsboard.Presentation.ViewModels;

namespace Planungsboard.Presentation.Views
{
    public partial class NewEntityWindows : Window
    {
        public NewEntityWindows()
        {
            this.InitializeComponent();
        }

        public object Result => new ViewModelLocator().NewEntityWindowsViewModel.Result;

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