using CustomerMgt.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMgt.Data
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = AddressType.Office;
                address.StreetLine1 = "Bode";
                address.StreetLine2 = "Thomas";
                address.City = "Surulere";
                address.State = "Lagos";
                address.Country = "Nigeria";
                address.PostalCode = "10001";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = AddressType.Home,
                StreetLine1 = "Bag",
                StreetLine2 = "Show",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = AddressType.Office,
                StreetLine1 = "Bode",
                StreetLine2 = "Thomas",
                City = "Surulere",
                State = "Lagos",
                Country = "Nigeria",
                PostalCode = "10001"
            };
            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address address)
        {
            return true;
        }
    }
}
