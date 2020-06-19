using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GetThatLook.Models
{
    public partial class Customer
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(150)]
        public string Address { get; set; }
        [Key]
        public int PhoneNumber { get; set; }
        [Required]
        [StringLength(50)]
        public string PostalCode { get; set; }
        [Required]
        [StringLength(50)]
        public string Province { get; set; }
    }
}
