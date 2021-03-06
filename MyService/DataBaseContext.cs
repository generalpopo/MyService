﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyService
{
    public class DataBaseContext: DbContext
    {

        public DataBaseContext() : base("MyDBConnectionString")
        {

        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<User> Users { get; set; }
    }
}