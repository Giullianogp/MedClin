using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedClin.Core.ViewModels.Services;
using Xamarin.Forms;

namespace MedClin.Core.Views.Services
{
    public class MessageService : IMessageService
    {
        public async Task ShowAsync(string message)
            => await Application.Current.MainPage.DisplayAlert("MedClin", message, "OK");

    }
}
