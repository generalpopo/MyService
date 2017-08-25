using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyService
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }
        public string AlbumDescription { get; set; }
        public DateTime AlbumReleaseDate { get; set; }

        public virtual User User { get; set; }

    }
}