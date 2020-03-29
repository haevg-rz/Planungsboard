using System;
using System.Collections.Generic;
using System.Text;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace Planungsboard.Presentation.ViewModels
{
    public class NewEntityWindowsViewModel : ViewModelBase
    {
        private object instance;

        public NewEntityWindowsViewModel()
        {
            if (base.IsInDesignMode)
            {
                this.Instance = new Team() {Name = "TestTeam from NewEntityWindowsViewModel"};
                // this.Instance = new Card() {Title = "Test Card"};
            }
            else
            {
                this.SaveCommand = new RelayCommand(SaveCommandHandling);
            }
        }

        private void SaveCommandHandling()
        {
            this.Result = Instance;
        }

        public RelayCommand SaveCommand { get; set; }

        public object Instance
        {
            get => instance;
            set { base.Set(ref instance, value); }
        }

        public object Result { get; set; }

        public string TypeName => Instance?.GetType().Name ?? "Error";
    }
}