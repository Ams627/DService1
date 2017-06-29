using MvvmFoundation.Wpf;
using System.Windows;
using System.Windows.Input;

namespace DService1
{
    class ViewModel
    {
        public ICommand MyCommand { get; set; }
        public IDialogService DialogService { get; set; }
        public ViewModel(IDialogService dialogService)
        {
            this.DialogService = dialogService;
            MyCommand = new RelayCommand(() =>
            {
                DialogService.ShowDialog();
            });
        }
    }
}
