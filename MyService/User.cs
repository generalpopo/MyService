using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace MyService
{
    [DataContract]

    public class User
    {
        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string EmailAddress { get; set; }
        [DataMember]
        public string Password { get; set; }

        public virtual List<Album> Albums { get; set; }

    }
}