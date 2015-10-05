using Newtonsoft.Json;

namespace Haltaalam.Models
{
    public class Images
    {
        public LowResolution LowResolution
        { get; set; }
        public Thumbnail Thumbnail
        { get; set; }

        [JsonProperty("standard_resolution")]
        public StandardResolution StandardResolution
        { get; set; }
    }
}