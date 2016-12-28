using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedClin.Core.Models;
using MedClin.Core.Views;

namespace MedClin.Core.ViewModels
{
    public class MasterViewModel : ViewModelBase
    {
        private ObservableCollection<Menu> _menu;
        public ObservableCollection<Menu> Menu
        {
            get { return _menu; }
            set { _menu = value; Notify(); }
        }


        public MasterViewModel()
        {
            Menu = new ObservableCollection<Menu>
            {
                new Menu {Option = "Agenda", Tipo = typeof(AgendaView), Image = "agenda.png"},
                new Menu {Option = "Pacientes", Tipo = typeof(PacienteView), Image = "paciente.png"},
                new Menu {Option = "Gerencial", Tipo = typeof(GerencialView), Image = "relatorio.png"}

            };
        }

    }
}
