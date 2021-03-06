using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeShop.Core.Entity
{
    public class OrderItem : IEntityBase
    {
        public Guid Id { get; private set; }
        public Guid ProductId { get; private set; }
        public int Quantity  { get; private set; }
        public decimal Price { get; private set; }

        public OrderItem(Guid id, Guid productId, int quantity, decimal price)
        {
            Id = id;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
        }
    }
}
