using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMgt.BL
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string ProductionDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        public Product Retrieve(int id)
        {
            return new Product();
        }

        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
