using CustomerMgt.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMgt.BL
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer() : this(0)
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }
        public int CustomerId { get; private set; }
        public string FirstName { get; set; }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string FullName
        {
            get 
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += " ";
                    }
                    fullName += FirstName;
                }
                return fullName; 
            }
        }
        public string EmailAddress { get; set; }
        public List<Address> AddressList { get; set; }
        public int CustomerType { get; set; }

        public override string ToString()
        {
            return FullName;
        }

        public static int InstanceCount { get; set; }

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public string LogError()
        {
            var logString = CustomerId + ": " +
                             FullName + " " + "Email: " +
                             EmailAddress + " " + "Status: " +
                             EntityState.ToString();

            return logString;
        }

        public string Log() =>
            $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";
    }
}
