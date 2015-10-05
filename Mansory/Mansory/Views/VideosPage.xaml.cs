using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.YouTube.v3.Data;
using Mansory.Models;
using Mansory.ViewModels;
using Xamarin.Forms;

namespace Mansory.Views
{
    public partial class VideosPage : ContentPage
    {

        public VideosPage()
        {
            InitializeComponent();

            BindingContext = new MainViewModel();
        }

        private async void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {

            var youtubeVideo = e.Item as YoutubeVideo;

            await Navigation.PushAsync(new VideoPlayerPage());

            MessagingCenter.Send(youtubeVideo, "Hi", "https://www.youtube.com/watch?v=" + youtubeVideo.SearchResult.Id.VideoId);
        }
    }
}
