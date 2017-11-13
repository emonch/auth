using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using MySql.Data.Entity;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace AuthExample.Models
{
    public class UserModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A {0} deve ter pelo menos {2} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Repita a Senha")]
        [Compare("Password", ErrorMessage = "A senha e a repetição não conferem.")]
        public string ConfirmPassword { get; set; }
    }
}