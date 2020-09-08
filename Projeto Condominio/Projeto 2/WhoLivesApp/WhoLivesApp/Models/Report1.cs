using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.ComponentModel.DataAnnotations;


namespace WhoLivesApp.Models
{
    public class Report1
    {
        [Key]
        public int MOR_ID { get; set; }

        public int AP_NUMERO { get; set; }

        public string MOR_NOME { get; set; }

        public string MOR_SOBRENOME { get; set; }

        public bool AP_ATENCAO { get; set; }

        public string FUN_NOME { get; set; }




    }
}