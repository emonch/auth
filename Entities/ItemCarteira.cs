using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AuthExample.Entities
{
    public class ItemCarteira
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Usuario { get; set; }
        [Required]
        public string Ativo { get; set; }
        [Required]
        public double Quantidade { get; set; }
    }
}