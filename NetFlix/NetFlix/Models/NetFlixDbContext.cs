using System;
using System.Collections.Generic;
using System.Data.Entity;//
using System.Linq;
using System.Web;

namespace NetFlix.Models
{
    public class NetFlixDbContext : DbContext   
    {
        public DbSet<Serie> Series { get; set; } //DbSet is a collection Series = name of table
    }
}