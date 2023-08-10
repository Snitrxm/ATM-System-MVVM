using ATM_System_MVVM.Stores;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_System_MVVM.ViewModels
{
    public partial class HomeViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;

        public HomeViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        [RelayCommand]
        public void NavigateToAccountView()
        {
            _navigationStore.CurrentViewModel = new AccountViewModel();
        }
    }
}
