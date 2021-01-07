using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebUI.Data
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Vyplňte heslo, prosím")]
        public string password { get; set; }

        [Required(ErrorMessage = "Vplňte uživatelské jméno, prosím")]
        public string username { get; set; }
    }
}
