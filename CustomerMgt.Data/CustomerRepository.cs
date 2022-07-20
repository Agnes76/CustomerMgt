using CustomerMgt.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMgt.Data
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.FirstName = "Agnes";
                customer.LastName = "Ugochukwu";
                customer.EmailAddress = "agnes@gmail.com";
            }

            return customer;
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
