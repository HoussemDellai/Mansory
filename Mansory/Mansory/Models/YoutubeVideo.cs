using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.YouTube.v3.Data;

namespace Mansory.Models
{
    public class YoutubeVideo
    {

        public string VideoUrl
        { get; set; }

        public SearchResult SearchResult
        { get; set; }
    }
}
