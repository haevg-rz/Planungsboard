using GalaSoft.MvvmLight.Ioc;

namespace Planungsboard.Presentation.ViewModels
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<NewEntityWindowsViewModel>();
        }

        public MainViewModel MainViewModel => SimpleIoc.Default.GetInstance<MainViewModel>();
        public NewEntityWindowsViewModel NewEntityWindowsViewModel => SimpleIoc.Default.GetInstance<NewEntityWindowsViewModel>();
    }
}