using System;

namespace MovieRentals.Models
{
    public class Customer
    {
        public int CustomerId {get;set;}
        public string CustomerName {get;set;}
        public bool PremiumMember {get;set;}

        public Customer(int id, string name,bool premium)
        {
            this.CustomerId = id;
            this.CustomerName = name;
            this.PremiumMember = premium;
        }
    }
}