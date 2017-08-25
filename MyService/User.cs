using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace MyService
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }

        public virtual Collection<Album> Album { get; set; }
    }
}