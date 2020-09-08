using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace WhoLivesApp.Models
{
    public class Report2Context : DbContext
    {
        public Report2Context() : base("BancoApartamentos")
        {

        }
        public DbSet<Report2> Report2List { get; set; }
    }
}