using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PS2.Models
{
    public class Menu
    {
        public int id { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
        [MaxLength(150)]
        [Display(Name = "Descripción")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Precio")]
        public decimal Price { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Tipo")]
        public string Tipo { get; set; }
        public Byte[] Image { get; set; }
    }
}