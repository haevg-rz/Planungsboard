using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace Planungsboard.Presentation.ViewModels
{
    public class NewEntityWindowsViewModel : ViewModelBase
    {
        private object instance;

        public NewEntityWindowsViewModel()
        {
            if (this.IsInDesignMode)
                this.Instance = new Team {Name = "TestTeam from NewEntityWindowsViewModel"};
            // this.Instance = new Card() {Title = "Test Card"};
            else
                this.SaveCommand = new RelayCommand(this.SaveCommandHandling);
        }

        public RelayCommand SaveCommand { get; set; }

        public object Instance
        {
            get => this.instance;
            set => this.Set(ref this.instance, value);
        }

        public object Result { get; set; }

        public string TypeName => this.Instance?.GetType().Name ?? "Error";

        private void SaveCommandHandling()
        {
            this.Result = this.Instance;
        }
    }
}