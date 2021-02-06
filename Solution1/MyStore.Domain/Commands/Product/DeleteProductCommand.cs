using System;
using System.Collections.Generic;
using System.Text;

namespace MyStore.Domain.Commands.Product
{
    public class DeleteProductCommand : ProductCommand
    {
        
        public DeleteProductCommand(int id)
        {
            this.Id = id;
        }
    }
}
