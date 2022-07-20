using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMgt.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }
        public int OrderItemId { get; set; }
        public Product Product { get; set; }    
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }

        public bool Validate()
        {
            var isValid = true;

            //if (string.IsNullOrWhiteSpace()) isValid = false;
            //if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public OrderItem Retrieve(int id)
        {
            return new OrderItem();
        }

        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
