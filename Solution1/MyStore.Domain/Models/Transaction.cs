using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Domain.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int prodId { get; set; }
        public int storeId { get; set; }
        public string Date { get; set; }
    }
}
