using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mansory.Views;
using Xamarin.Forms;

namespace Mansory
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(
               new CarouselPage
               {
                   Title = "Mansory",
                   Children =
                   {
                        //new HomePage(),
                        new ListCarsPage(),
                        new TweetsPage(),
                        new VideosPage(),
                   }
               })
            {
                //Tint = Color.Green,
                BarBackgroundColor = Color.Red,
                BarTextColor = Color.White
            };
        }
    }
}
