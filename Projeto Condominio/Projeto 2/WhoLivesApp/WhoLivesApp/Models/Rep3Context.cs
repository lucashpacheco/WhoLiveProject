using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WhoLiveApp.Models;

namespace WhoLivesApp.Models
{
    public class Report3 : DbContext
    {
        public Report3() : base("BancoApartamentos")
        {

        }
        public DbSet<Apartament> Apartaments { get; set; }
    }
}