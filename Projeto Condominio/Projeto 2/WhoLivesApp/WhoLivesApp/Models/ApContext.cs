using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WhoLiveApp.Models;

namespace WhoLivesApp.Models
{
    public class ApContext : DbContext
    {
        public ApContext() : base("BancoApartamentos")
        {

        }
        public DbSet<Apartament> Apartaments { get; set; }
    }
}