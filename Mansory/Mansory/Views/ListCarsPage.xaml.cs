using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mansory.ViewModels;
using Xamarin.Forms;

namespace Mansory.Views
{
    public partial class ListCarsPage : ContentPage
    {
        public ListCarsPage()
        {
            InitializeComponent();

            BindingContext = new MainViewModel();
        }
    }
}
