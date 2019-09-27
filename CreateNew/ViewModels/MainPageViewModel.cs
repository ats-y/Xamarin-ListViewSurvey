using System;
using CreateNew.Models;
using Prism.Navigation;
using Reactive.Bindings;

namespace CreateNew.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Prism.Forms!";    
        }
    }
}
