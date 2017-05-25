using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoDatabase.Objects
{
    public class Video
    {
        public int ID { get; set; }
        public string FileName { get; set; }
        public string OriginalFileName { get; set; }
        public string FileLocation { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string InfoURL { get; set; }
        public int SeriesID { get; set; }
        public string SeriesName { get; set; }
    }
}
