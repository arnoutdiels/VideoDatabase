using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoDatabase.Objects
{
    class Episode : Video
    {
        public Episode()
        {
        }
        public Episode(int id,string filename, string originalfilename, string filelocation,
            DateTime releasedate, string infourl, int seriesid, string seriesname,
            int season, int episodenumber)
        {
            ID = id;
            FileName = filename;
            OriginalFileName = originalfilename;
            FileLocation = filelocation;
            ReleaseDate = releasedate;
            InfoURL = infourl;
            seriesid = SeriesID;
            SeriesName = seriesname;
            Season = season;
            EpisodeNumber = episodenumber;
        }

        public int Season { get; set; }
        public int EpisodeNumber { get; set; }


    }
}
