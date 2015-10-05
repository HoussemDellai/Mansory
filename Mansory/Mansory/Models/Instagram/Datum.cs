using Newtonsoft.Json;

namespace Haltaalam.Models
{
    public class Datum
    {
        public object Attribution
        { get; set; }
        public object[] Tags
        { get; set; }
        public object Location
        { get; set; }

        public Comments Comments
        { get; set; }
        public string Filter
        { get; set; }
        public string CreatedTime
        { get; set; }
        public string Link
        { get; set; }
        public Likes Likes
        { get; set; }
        public Images Images
        { get; set; }
        public object[] UsersInPhoto
        { get; set; }
        public Caption Caption
        { get; set; }
        public string Type
        { get; set; }
        public string Id
        { get; set; }
        public User User
        { get; set; }
    }
}