using ATM_System_MVVM.Stores;
using ATM_System_MVVM.ViewModels;
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

namespace ATM_System_MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NavigationStore navigationStore = new();

        public MainWindow()
        {
            InitializeComponent();
            navigationStore.CurrentViewModel = new HomeViewModel(navigationStore);
            DataContext = new MainViewModel(navigationStore);
        }
    }
}
