using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using AuthExample.Models;

namespace AuthExample.Entities
{
    public class Ativo
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }
        public bool Transferivel { get; set; }
    }
}