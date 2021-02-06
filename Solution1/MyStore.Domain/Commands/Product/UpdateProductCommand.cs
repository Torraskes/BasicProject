using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Domain.Commands.Product
{
    public class UpdateProductCommand : ProductCommand
    {
        public UpdateProductCommand(int Id,string SKU, string Name, float Cost, int InExistance, string Brand)
        {
            this.Id = Id;
            this.SKU = SKU;
            this.Name = Name;
            this.Cost = Cost;
            this.InExistance = InExistance;
            this.Brand = Brand;
        }
    }
}
