using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DemoTransactionDone.Mvvm.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTransactionDone.Mvvm.ViewModels
{
    
    public partial class HomeViewModel : ObservableObject
    {


        [RelayCommand]
        public async void GoToMain()
        {
            await Shell.Current.GoToAsync(nameof(HomePage));
        }
    }
}
