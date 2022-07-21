using CustomerMgt.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMgt.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }
        public int ProductId { get; private set; }

        private string _productName;
        public string ProductName 
        { 
            get 
            { 
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value;
            }
        }
        public string ProductionDescription { get; set; }
        public decimal? CurrentPrice { get; set; }


        public override string ToString()
        {
            return ProductName;
        }
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

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
           
            return isValid;
        }

        public string Log()
        {
            throw new NotImplementedException();
        }
    }
}
