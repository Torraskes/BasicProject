using MyStore.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Domain.Commands.Product
{
    public abstract class ProductCommand : Command
    {
        public string SKU { get; protected set; }
        public string Name { get; protected set; }
        public float Cost { get; protected set; }
        public int InExistance { get; protected set; }
        public string Brand { get; protected set; }
    }
}
