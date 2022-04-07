using AwesomeShop.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeShop.Core.Entity
{
    public class Order : AggregateRoot
    {
        public decimal TotalPrice { get; private set; }
        public Customer Customer { get; private set; }
        public DeliveryAddress  DelivaryAddress { get; private set; }
        public PaymentAddress  PaymentAddress { get; private set; }
        public PaymentInfo  PaymentInfo { get; private set; }
        public List<OrderItem>  OrderItems { get; private set; }
        public DateTime CreatAt { get; private set; }
    }
}
