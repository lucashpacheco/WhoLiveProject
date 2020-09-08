using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WhoLivesApp.Models;

namespace WhoLivesApp.Models
{
    public class Rep1Context : DbContext
    {
        public Rep1Context() : base("BancoApartamentos")
        {

        }
        public DbSet<Report1> Report1List { get; }
    }
}