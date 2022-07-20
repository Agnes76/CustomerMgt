using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMgt.BL
{
    public class Order
    {
        public Order()
        {
                
        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }
        public int OrderId { get; set; }
        public string ShippingAddress { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public Customer Customer { get; set; }
        public OrderItem OrderItem { get; set; }

        public bool Validate()
        {
            var isValid = true;

           // if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(ShippingAddress)) isValid = false;

            return isValid;
        }
    }
}
