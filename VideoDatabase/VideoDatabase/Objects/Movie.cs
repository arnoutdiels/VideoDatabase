using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoDatabase.Objects
{
    public class Movie : Video
    {
        public int PrequelID { get; set; }
        public string PrequelName { get; set; }
        public int SequelID { get; set; }
        public string SequelName { get; set; }
        
    }
}
