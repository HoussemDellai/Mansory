using System.Collections.Generic;

namespace Haltaalam.Models
{
    public class Rootobject
    {
        public Pagination Pagination
        { get; set; }
        public Meta Meta
        { get; set; }
        public List<Datum> Data
        { get; set; }
    }
}