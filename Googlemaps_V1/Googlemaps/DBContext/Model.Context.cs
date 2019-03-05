using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using Googlemaps.Models;

namespace Googlemaps.DBContext
{
    public partial class SampleDBEntities : DbContext
    {
        public SampleDBEntities()
            : base("name=SampleDBEntities")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }


        public DbSet<SchoolInfo> SchoolInfo { get; set; }

    }
}