using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.YouTube.v3.Data;
using Haltaalam.Models;
using Mansory.Models;
using Mansory.Services;

namespace Mansory.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private List<Datum> _instagramItems;
        private List<YoutubeVideo> _videosList;
        private List<Tweet> _tweetsList;

        public List<Datum> InstagramItems
        {
            get { return _instagramItems; }
            set
            {
                _instagramItems = value;
                OnPropertyChanged();
            }
        }

        public List<YoutubeVideo> VideosList
        {
            get { return _videosList; }
            set
            {
                _videosList = value;
                OnPropertyChanged();
            }
        }

        public List<Tweet> TweetsList
        {
            get { return _tweetsList; }
            set
            {
                _tweetsList = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            DownloadDataAsync();
        }

        private async Task DownloadDataAsync()
        {
            var dataServices = new DataServices();

            InstagramItems = await dataServices.GetInstagramImagesUrlsAsync();

            TweetsList = await dataServices.GetTweetsAsync();

            VideosList = await dataServices.GetYoutubeVideosAsync();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
