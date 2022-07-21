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
        public CustomerRepository()
        {
            addressRepo = new AddressRepository();
        }
        private AddressRepository addressRepo { get; set; }
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.FirstName = "Agnes";
                customer.LastName = "Ugochukwu";
                customer.EmailAddress = "agnes@gmail.com";
                customer.AddressList = addressRepo.RetrieveByCustomerId(customerId).ToList();
            }
            Console.WriteLine($"Customer: {customer.ToString()}");

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
