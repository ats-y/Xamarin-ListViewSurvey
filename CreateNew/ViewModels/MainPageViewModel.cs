using System;
using Prism.Navigation;

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
