using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Domain.Commands.Product
{
    public class CreateProductCommand : ProductCommand
    {
        public CreateProductCommand(string SKU, string Name, float Cost, int InExistance, string Brand)
        {
            this.SKU = SKU;
            this.Name = Name;
            this.Cost = Cost;
            this.InExistance = InExistance;
            this.Brand = Brand;
        }
    }
}
