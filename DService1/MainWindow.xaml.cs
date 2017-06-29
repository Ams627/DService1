using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DService1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var dialogViewModel = new DialogViewModel();
            var dialog = new ActualDialog<BlobDialog>(dialogViewModel);
            var viewModel = new ViewModel(dialog);
            this.DataContext = viewModel;
        }
    }
}
