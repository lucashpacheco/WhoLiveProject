using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.ComponentModel.DataAnnotations;


namespace WhoLivesApp.Models
{
    public class Report4
    {
        [Key]
        public int AP_ID { get; set; }

        public int Apartamento { get; set; }

        public string PCD { get; set; }


    }
}