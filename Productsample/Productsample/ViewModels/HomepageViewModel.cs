using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace Productsample.ViewModels
{
	public class HomepageViewModel : BindableBase
	{
        INavigationService _navigationService { get; set; }
        public DelegateCommand bindmenupage { get; set; }

        public HomepageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            bindmenupage = new DelegateCommand(Showmaster);
        }
        void Showmaster()
        {
            _navigationService.NavigateAsync("Loginpage");
        }
	}
}
