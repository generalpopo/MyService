using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MyService
{
    [DataContract]
    [KnownType(typeof(User))]
    public class Album
    {
        [DataMember]
        public int AlbumId { get; set; }
        [DataMember]
        public string AlbumName { get; set; }
        [DataMember]
        public string AlbumDescription { get; set; }
        [DataMember]
        public DateTime AlbumReleaseDate { get; set; }
        [DataMember]
        public virtual User User { get; set; }

    }
}