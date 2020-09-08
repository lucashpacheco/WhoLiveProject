using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WhoLivesApp.Models;

namespace WhoLivesApp.Models
{
    public class Report4Context : DbContext
    {
        public Report4Context() : base("BancoVeiculos")
        {

        }
        public DbSet<Report4> Report4List { get; set; }
    }
}