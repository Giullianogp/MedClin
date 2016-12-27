using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedClin.Core.Models;
using Xamarin.Forms;

namespace MedClin.Core.Views
{
    public partial class MainView 
    {
        public MainView()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            MasterPage.List.ItemSelected += OnSelect;
        }

        private void OnSelect(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Menu;
            if (item == null) return;

            Detail = new NavigationPage((Page)Activator.CreateInstance(item.Tipo));
            MasterPage.List.SelectedItem = null;
            IsPresented = false;
        }
    }
}
