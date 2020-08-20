using System;
using System.Collections.Generic;
using System.Text;
using Shared;

namespace CommerceLibrary
{
    public class Customer: Person
    {
        public string LoyaltyId;
        public Customer(string firstName, string lastName, string loyaltyId)
            :base(firstName, lastName)
        {
            LoyaltyId = loyaltyId;
        }
    }
}
