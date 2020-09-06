using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WhoLivesApp.Models
{
    public class Resident111
    {
        //[Key]
        //public int MOR_ID { get; set; }
        public string MOR_NOME { get; set; }
        public string MOR_SOBRENOME { get; set; }
        public int AP_NUMERO { get; set; }
        
    }
}