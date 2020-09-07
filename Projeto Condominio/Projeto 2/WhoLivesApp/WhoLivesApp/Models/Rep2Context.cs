using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WhoLiveApp.Models;

namespace WhoLivesApp.Models
{
    public class Report2 : DbContext
    {
        public Report2() : base("BancoApartamentos")
        {

        }
        public DbSet<Apartament> Apartaments { get; set; }
    }
}