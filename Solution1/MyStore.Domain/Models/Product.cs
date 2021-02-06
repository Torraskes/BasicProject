using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyStore.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }    
        [Required]
        [MaxLength(100)]
        public string SKU { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }        
        public float Cost { get; set; }
        public int InExistance { get; set; }        
        public string Brand { get; set; }
    }
}
