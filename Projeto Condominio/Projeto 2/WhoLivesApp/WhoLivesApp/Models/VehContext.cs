using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WhoLiveApp.Models;

namespace WhoLivesApp.Models
{


    public class VehContext : DbContext
    {
        public VehContext() : base("BancoVeiculos")
        {

        }
        public DbSet<Vehicle> Vehicles { get; set; }
    }
    
}