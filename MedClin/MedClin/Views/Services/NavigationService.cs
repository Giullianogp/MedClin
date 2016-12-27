using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedClin.Core.ViewModels.Services;
using Xamarin.Forms;

namespace MedClin.Core.Views.Services
{
    public class NavigationService : INavigationService
    {
        public void NavigateToAgenda()
        {
            var masterDetailPage = Application.Current.MainPage as MasterDetailPage;
            if (masterDetailPage == null) return;

            masterDetailPage.Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(AgendaView)));
            masterDetailPage.IsPresented = false;
        }

        public void NavigateToConfig()
        {
            var masterDetailPage = Application.Current.MainPage as MasterDetailPage;
            if (masterDetailPage == null) return;

            masterDetailPage.Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ConfigView)));
            masterDetailPage.IsPresented = false;
        }

        public void NavigateToPaciente()
        {
            var masterDetailPage = Application.Current.MainPage as MasterDetailPage;
            if (masterDetailPage == null) return;

            masterDetailPage.Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(PacienteView)));
            masterDetailPage.IsPresented = false;
        }

        //async Task INavigationService.NavigateToDetalheAgenda(AgendaMobile agenda) =>
        //    await (Application.Current.MainPage as MasterDetailPage).Detail.Navigation.PushAsync(new AgendaDetalheView(agenda), true);
    }
}
