using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Productsample.ViewModels
{
	public class LoginpageViewModel : BindableBase,INavigatedAware
	{
        public DelegateCommand ProductNaviButton { get; private set; }
      INavigationService _navigationService { get; set; }
        public LoginpageViewModel(INavigationService navigationService)
        {
            ProductNaviButton = new DelegateCommand(NavitoProduct);
            _navigationService = navigationService;
        }

        public void NavitoProduct()
        {
            _navigationService.NavigateAsync("ProductMenu");
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            
        }
    }
}
