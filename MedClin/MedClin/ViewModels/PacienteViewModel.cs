using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MedClin.Core.ViewModels.Services;
using Xamarin.Forms;

namespace MedClin.Core.ViewModels
{
    public class PacienteViewModel : ViewModelBase
    {
        private INavigationService _navigationService;
        private IMessageService _messageService;

        public PacienteViewModel()
        {
            _navigationService = DependencyService.Get<INavigationService>();
            _messageService = DependencyService.Get<IMessageService>();
        }


        public ICommand PacienteSelectCommand =>
            new Command(async () => await _navigationService.NavigateToPaciente());


    }
}
