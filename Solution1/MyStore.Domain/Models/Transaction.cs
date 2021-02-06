using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyStore.Domain.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        [Required]        
        public int prodId { get; set; }
        [Required]        
        public int storeId { get; set; }
        [Required]
        [MaxLength(20)]
        public string Date { get; set; }
    }
}
