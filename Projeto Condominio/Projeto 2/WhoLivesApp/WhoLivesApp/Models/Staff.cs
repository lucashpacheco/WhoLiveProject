using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.ComponentModel.DataAnnotations;


namespace WhoLivesApp.Models
{
    public class Staff
    {
        [Key]
        public int FUN_ID { get; set; }

        //[Required(ErrorMessage = "Informe o nome do funcionario", AllowEmptyStrings = false)]
        public string FUN_NOME { get; set; }

        //[Required(ErrorMessage = "Informe o sobrenome do funcionario", AllowEmptyStrings = false)]
        public string FUN_SOBRENOME { get; set; }

        //[Required(ErrorMessage = "Informe o cargo do funcionario", AllowEmptyStrings = false)]
        public string FUN_CARGO { get; set; }
    }
}