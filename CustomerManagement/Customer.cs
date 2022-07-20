using System;

namespace CustomerManagement
{
    public class Customer
    {
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
            get { return LastName + " " + FirstName; }
        }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
    }
}