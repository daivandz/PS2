using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PS2.Models
{
    public class Order
    {
        public int id { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Cliente")]
        public string Client { get; set; }
        [Required]
        [Display(Name = "Cantidad")]
        public int Quantity { get; set; }
        [Display(Name = "Total")]
        public decimal Total { get; set; }
        [MaxLength(50)]
        [Display(Name = "Status")]
        public string Status { get; set; }
        public int MenuId { get; set; }
        [ForeignKey("MenuId")]
        public Menu Menu { get; set; }
    }

}