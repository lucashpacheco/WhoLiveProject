using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WhoLivesApp.Models
{
    public class ResContextIndex : DbContext
    {
        public ResContextIndex() : base("BancoMoradores")
        {

        }
        public DbSet<ResidentIndex> Residents{ get; set; }
        //public DbSet.SQLQuery

    }
}