using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.ComponentModel.DataAnnotations;


namespace WhoLiveApp.Models
    {
        public class Vehicle
        {
            [Key]
            public int VEI_ID { get; set; }

            //[Required(ErrorMessage = "Informe o modelo do veiculo", AllowEmptyStrings = false)]
            public string VEI_MOD { get; set; }

            //[Required(ErrorMessage = "Informe a cor do veiculo", AllowEmptyStrings = false)]
            public string VEI_COR { get; set; }

            //[Required(ErrorMessage = "Informe a placa do veiculo", AllowEmptyStrings = false)]
            public string VEI_PLACA { get; set; }

            //[Required(ErrorMessage = "Informe o AP do veiculo", AllowEmptyStrings = false)]
            public int VEI_AP_ID { get; set; }
        }
    }
