using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WhoLiveApp.Models;

namespace WhoLivesApp.Models
{
    
    public class StaContext : DbContext
    {
        public StaContext() : base("BancoFuncionarios")
        {

        }
        public DbSet<Staff> Staffs { get; set; }
    }
    
}