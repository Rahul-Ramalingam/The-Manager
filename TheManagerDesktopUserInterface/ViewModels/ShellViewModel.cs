using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace TheManagerDesktopUserInterface.ViewModels
{
    
    public class ShellViewModel : Conductor<object>
    {
        private LoginViewModel _loginVm;

        public ShellViewModel(LoginViewModel loginVm)
        {
            _loginVm = loginVm;
            ActivateItemAsync(_loginVm);
        }
    }
}
