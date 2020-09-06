using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.ComponentModel.DataAnnotations;


namespace WhoLivesApp.Models
{
    public class Resident
    {
        [Key]
        public int MOR_ID { get; set; }
        //[Required(ErrorMessage = "Informe o nome do morador", AllowEmptyStrings = false)]
        public string MOR_NOME { get; set; }
        //[Required(ErrorMessage = "Informe o sobrenome do morador", AllowEmptyStrings = false)]
        public string MOR_SOBRENOME { get; set; }
        //[Required(ErrorMessage = "Informe o ap do morador", AllowEmptyStrings = false)]
        public int MOR_AP_ID { get; set; }
        //[Required(ErrorMessage = "Informe o fun que reg o morador", AllowEmptyStrings = false)]
        public int MOR_FUN_ID { get; set; }
    }
}