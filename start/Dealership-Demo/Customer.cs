using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership_Demo
{
    public class Customer : Dealership
    {
        protected string CustomerFName { get; set; }
        protected string CustomerLName { get; set; }
        protected string CustomerEmail { get; set; }
        protected string CustomerPhone { get; set; }
        protected string CustomerHomeDealership { get; set; }

        public Customer() { }

        public Customer(string fName, string lName, string email, string number, string homeDealership)
        {
            this.CustomerFName = fName;
            this.CustomerLName = lName;
            this.CustomerEmail = email;
            this.CustomerPhone = number;
            this.CustomerHomeDealership = homeDealership;
        }

        public string GetCustomerEmail()
        {
            return this.CustomerEmail;
        }

        public override string ToString()
        {
            return FormatString(String.Format($"  Name: {this.CustomerFName} {this.CustomerLName} \nEmail: {this.CustomerEmail} \nPhone: {this.CustomerPhone} \nHome Dealership Name: {this.CustomerHomeDealership} \n"));
        }
    }
}