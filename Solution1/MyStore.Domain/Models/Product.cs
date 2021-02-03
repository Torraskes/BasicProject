using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }        
        public string SKU { get; set; }
        public string Name { get; set; }
        public float Cost { get; set; }
        public int InExistance { get; set; }
        public string Brand { get; set; }
    }
}
