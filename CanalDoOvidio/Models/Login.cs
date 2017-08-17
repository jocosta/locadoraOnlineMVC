using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CanalDoOvidio.Models
{
    public class Login
    {
        [Display(Name = "E-mail")]
        [EmailAddress]
        [Required(ErrorMessage = "Informe o seu e-mail", AllowEmptyStrings = false)]
        public string Email { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Informe a sua senha", AllowEmptyStrings = false)]
        public string Senha { get; set; }
    }
}