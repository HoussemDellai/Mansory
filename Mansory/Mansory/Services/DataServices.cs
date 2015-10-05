using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using Haltaalam.Models;
using Mansory.Models;
using Newtonsoft.Json;

namespace Mansory.Services
{
    public class DataServices
    {

        public async Task<List<Datum>> GetInstagramImagesUrlsAsync()
        {
            var httpClient = new HttpClient();

            var json = await httpClient.GetStringAsync("http://socialmediaservices.azurewebsites.net/api/Instagram/Details/1447492830");

            return JsonConvert.DeserializeObject<List<Datum>>(json);
        }

        public async Task<List<YoutubeVideo>> GetYoutubeVideosAsync()
        {

            var httpClient = new HttpClient();

            var json = await httpClient.GetStringAsync("http://socialmediaservices.azurewebsites.net/api/youtube/Mansory");

            var result = JsonConvert.DeserializeObject<List<YoutubeVideo>>(json);

            return result;
        }

        //public async Task<List<SearchResult>> GetYoutubeVideosAsync()
        //{
        //    try
        //    {

        //        var youtubeService = new YouTubeService(new BaseClientService.Initializer()
        //        {
        //            ApiKey = "AIzaSyDOHaKdd-aN4fEyo24JR9fXa0yugHKfNcc",
        //            ApplicationName = this.GetType().ToString()
        //        });






        //        var searchListRequest = youtubeService.Search.List("snippet");
        //        searchListRequest.Q = "Mansory"; // Replace with your search term.
        //        searchListRequest.MaxResults = 50;

        //        //searchListRequest.
        //        searchListRequest.Type = "video";
        //        searchListRequest.VideoSyndicated = SearchResource.ListRequest.VideoSyndicatedEnum.True__;

        //        // Call the search.list method to retrieve results matching the specified query term.
        //        var searchListResponse = await searchListRequest.ExecuteAsync();

        //        var videos = new List<SearchResult>();
        //        List<string> channels = new List<string>();
        //        List<string> playlists = new List<string>();

        //        // Add each result to the appropriate list, and then display the lists of
        //        // matching videos, channels, and playlists.
        //        foreach (var searchResult in searchListResponse.Items)
        //        {
        //            switch (searchResult.Id.Kind)
        //            {
        //                case "youtube#video":
        //                    videos.Add(searchResult);

        //                    //var videoLink = (await YouTube.GetVideoUriAsync(videoV3.Snippet.ResourceId.VideoId, YouTubeQuality.QualityMedium)).Uri.AbsoluteUri,

        //                    //videos.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.VideoId));
        //                    break;

        //                case "youtube#channel":
        //                    channels.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.ChannelId));
        //                    break;

        //                case "youtube#playlist":
        //                    playlists.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.PlaylistId));
        //                    break;
        //            }
        //        }

        //        return videos;
        //    }
        //    catch (Exception exc)
        //    {

        //        throw;
        //    }

        //    return null;

        //    //var client = new HttpClient();

        //    //try
        //    //{
        //    //    var youtubeVideosJson = await client.GetStringAsync("http://houssemdellai-services.azurewebsites.net/api/youtube/UUeHFxhaUW300u9LToRhUsOQ/20");

        //    //    return JsonConvert.DeserializeObject<List<Video>>(youtubeVideosJson);
        //    //}
        //    //catch (Exception exc)
        //    //{
        //    //    Debug.WriteLine(exc.Data);
        //    //    Debug.WriteLine(exc.Message);
        //    //    Debug.WriteLine(exc.InnerException);

        //    //    return null;
        //    //}
        //}

        public async Task<List<Tweet>> GetTweetsAsync()
        {
            var client = new HttpClient();

            try
            {

                var tweetsJson = await client.GetStringAsync("http://houssemdellai-services.azurewebsites.net/api/tweets/MANSORYofficial/MANSORYofficial/20");

                return JsonConvert.DeserializeObject<List<Tweet>>(tweetsJson);
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Data);
                Debug.WriteLine(exc.Message);
                Debug.WriteLine(exc.InnerException);

                return null;
            }
        }
    }
}
