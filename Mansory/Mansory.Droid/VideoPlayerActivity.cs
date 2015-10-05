//using Android.App;
//using Android.Content;
//using Android.Content.PM;
//using Android.OS;
//using Android.Widget;
//using Mansory.Models;
//using Xamarin.Forms;
//using Android.Webkit;


//namespace Mansory.Droid
//{
//    [Activity(Label = "Videos", 
//              ScreenOrientation = ScreenOrientation.Landscape,
//              Theme = "@android:style/Theme.NoTitleBar")]
//    public class VideoPlayerActivity : Android.App.Activity
//    {

//        Android.Webkit.WebView web_view;

//        protected override void OnPostCreate(Bundle savedInstanceState)
//        {
//            MessagingCenter.Subscribe<YoutubeVideo, string>(this, "Hi", (sender, arg) =>
//            {
//                // do something whenever the "Hi" message is sent
//                // using the 'arg' parameter which is a string
//                PlayVideo(arg);
//            });

//            base.OnPostCreate(savedInstanceState);
//        }

//        protected override void OnCreate(Bundle bundle)
//        {
//            base.OnCreate(bundle);

//            //// Set our view from the "main" layout resource
//            //SetContentView(Resource.Layout.VideoPlayerLayout);

//            //web_view = FindViewById<Android.Webkit.WebView>(Resource.Id.webview);
//            //web_view.Settings.JavaScriptEnabled = true;
//            //web_view.LoadUrl("http://www.google.com");

//            SetContentView(Resource.Layout.VideoPlayerLayout);
//        }

//        private void PlayVideo(string videoUri)
//        {



//            //videoUri = "http://video.ch9.ms/ch9/a3cb/30d3a91e-fe60-417d-b66f-266e39d9a3cb/TWC920151002v2.mp4";

//            //"http://r3---sn-u0opnp5o5-u0oe.googlevideo.com/videoplayback?mm=31&mn=sn-u0opnp5o5-u0oe&mime=video/mp4&id=o-AIQRFS8HGNNulc4G_Y-MwLSnUaVgFnXwdF8nged6k6At&pl=24&sparams=dur,id,initcwndbps,ip,ipbits,itag,lmt,mime,mm,mn,ms,mv,pl,ratebypass,source,upn,expire&itag=22&ipbits=0&ip=197.14.52.219&fexp=9406124,9408136,9408710,9409069,9412839,9413309,9414764,9415365,9415485,9416023,9416126,9416179,9417701,9417707,9418153,9418448,9418777,9419298,9419446,9420348,9420373,9420930,9421013&source=youtube&ratebypass=yes&mv=m&ms=au&signature=59C07272CF035EA3CEEC59D110399799AA9684A8.768813D0267C7CDACE2A48BC7E82327D050C3D34&upn=kin-8j4cT9g&dur=692.790&mt=1443961564&initcwndbps=360000&lmt=1442646246578613&key=yt6&sver=3&expire=1443983237";

//            StartActivity(new Intent(Intent.ActionView, Android.Net.Uri.Parse(videoUri)));

//            //Log.i("Video", "Video Playing....");




//            //var videoView = FindViewById<VideoView>(Resource.Id.SampleVideoView);

//            //var uri = Android.Net.Uri.Parse(videoUri);

//            //videoView.SetVideoURI(uri);

//            //// doc : http://code.tutsplus.com/tutorials/streaming-video-in-android-apps--cms-19888
//            //var mediaController = new MediaController(this);

//            //mediaController.SetAnchorView(videoView);

//            //videoView.SetMediaController(mediaController);

//            //videoView.Start();
//        }
//    }
//}

