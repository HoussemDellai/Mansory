using Mansory.ViewModels;
using Xamarin.Forms;

namespace Mansory.Views
{
    public partial class TweetsPage : ContentPage
    {
        public TweetsPage()
        {
            InitializeComponent();

            BindingContext = new MainViewModel();
        }

        private void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var listView = sender as ListView;

            if (listView != null)
            {
                listView.SelectedItem = null;
            }
        }
    }
}
