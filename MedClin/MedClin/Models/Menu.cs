using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MedClin.Core.Models
{
    public class Menu
    {
        public string Option { get; set; }
        public Type Tipo { get; set; }
        public ImageSource Image { get; set; }
    }
}
