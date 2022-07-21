using CustomerMgt.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMgt.BL
{
    public class Order : EntityBase
    {
        public Order()
        {
                
        }
        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }
        public int OrderId { get; set; }
        public int ShippingAddressId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int CustomerId { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public override bool Validate()
        {
            var isValid = true;

           // if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            //if (string.IsNullOrWhiteSpace(ShippingAddress)) isValid = false;

            return isValid;
        }
    }
}
