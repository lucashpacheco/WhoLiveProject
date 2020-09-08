using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.ComponentModel.DataAnnotations;


namespace WhoLivesApp.Models
{
    public class Report2
    {
        [Key]
        public int AP_ID { get; set; }

        public int Apartamento { get; set; }

        public int Moradores { get; set; }

        //[Key]
        //public int AP_ID { get; set; }

        //public int AP_NUMERO { get; set; }

        //public bool AP_ATENCAO { get; set; }


    }
}