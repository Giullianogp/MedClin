using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MedClin.Core.Views
{
    public partial class MasterView : ContentPage
    {
        public ListView List => ListMenu;

        public MasterView()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }
    }
}
