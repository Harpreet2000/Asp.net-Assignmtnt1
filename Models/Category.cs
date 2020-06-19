using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GetThatLook.Models
{
    public partial class Category
    {
        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }
        [Key]
        [Column("CategoryID")]
        public int CategoryId { get; set; }
    }
}
