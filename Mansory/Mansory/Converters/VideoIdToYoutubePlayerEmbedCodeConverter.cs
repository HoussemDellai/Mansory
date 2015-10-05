//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Xamarin.Forms;

//namespace Mansory.Converters
//{
//    public class VideoIdToYoutubePlayerEmbedCodeConverter : IValueConverter
//    {
//        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
//        {
//            var videoId = value as string;

//            var htmlSource = new HtmlWebViewSource
//            {
//                Html = "<iframe width=\"300\" height=\"168\" src=\"https://www.youtube.com/embed/" + videoId + "\" frameborder=\"0\" allowfullscreen></iframe>"
//            };
//            //< iframe width = "854" height = "480" src = "https://www.youtube.com/embed/wci59Wk2mfE" frameborder = "0" allowfullscreen ></ iframe >
//            return htmlSource;
//        }

//        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
