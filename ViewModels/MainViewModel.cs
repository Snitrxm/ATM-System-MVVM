using ATM_System_MVVM.Stores;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_System_MVVM.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        public NavigationStore NavigationStore { get; }

        public ViewModelBase CurrentViewModel => NavigationStore.CurrentViewModel;

        public MainViewModel(NavigationStore navigationStore)
        {
            NavigationStore = navigationStore;
        }

        public void OnCurrentViewModelChanged()
        {
            System.Diagnostics.Debug.WriteLine(CurrentViewModel); //ViewModels.AccountViewModel
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }

}
