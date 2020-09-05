using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.ComponentModel.DataAnnotations;


namespace WebApplication1.Models
{
    public class Resident
    {
        public int MOR_ID { get; set; }
        [Required(ErrorMessage = "Informe o nome do usuário", AllowEmptyStrings = false)]
        public int MOR_NOME { get; set; }
        [Required(ErrorMessage = "Informe o sobrenome do usuário", AllowEmptyStrings = false)]
        public int MOR_SOBRENOME { get; set; }
        [Required(ErrorMessage = "Informe o ap do usuário", AllowEmptyStrings = false)]
        public int MOR_AP_ID { get; set; }
        [Required(ErrorMessage = "Informe o fun que reg o usuário", AllowEmptyStrings = false)]
        public int MOR_FUN_ID { get; set; }
    }
}