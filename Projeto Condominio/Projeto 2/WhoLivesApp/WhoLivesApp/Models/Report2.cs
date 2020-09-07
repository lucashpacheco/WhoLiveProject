using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.ComponentModel.DataAnnotations;


namespace WhoLiveApp.Models
{
    public class Report2
    {
        [Key]
        public int AP_ID { get; set; }

        //[Required(ErrorMessage = "Informe o numero do apartamento", AllowEmptyStrings = false)]
        public int AP_NUMERO { get; set; }

        //[Required(ErrorMessage = "Informe se o apartamento tem pessoas com necessidades especiais", AllowEmptyStrings = false)]
        public bool AP_ATENCAO { get; set; }


    }
}