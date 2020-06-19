using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GetThatLook.Models
{
    public partial class Product
    {
        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }
        [Key]
        public int ProductId { get; set; }
        [Column(TypeName = "money")]
        public decimal ProductPrice { get; set; }
        [Required]
        [StringLength(50)]
        public string ProductCategory { get; set; }
    }
}
