using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Xamarin.Forms;

namespace MedClin.Core
{
    public class App : Application
    {
        public App()
        {
            MobileCenter.Start(typeof(Analytics), typeof(Crashes));
            DependencyService.Register<ViewModels.Services.IMessageService, Views.Services.MessageService>();
            DependencyService.Register<ViewModels.Services.INavigationService, Views.Services.NavigationService>();
            
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                         new Label {
                             HorizontalTextAlignment = TextAlignment.Center,
                             Text = "Welcome to Xamarin Forms!"
                         }
                     }
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
