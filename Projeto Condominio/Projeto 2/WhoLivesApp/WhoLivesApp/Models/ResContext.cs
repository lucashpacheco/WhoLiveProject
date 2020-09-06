using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WhoLivesApp.Models
{
    public class ResContext : DbContext
    {
        public ResContext() : base("BancoMoradores")
        {

        }
        public DbSet<Resident> Residents{ get; set; }
        //public DbSet.SQLQuery

    }
}