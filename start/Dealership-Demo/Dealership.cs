using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dealership_Demo
{
    public class Dealership
    {
        protected string DealershipName { get; set; }
        protected string DealershipLocation { get; set; }

        public Dealership()
        {

        }
        public Dealership(string name, string location)
        {
            this.DealershipName = name;
            this.DealershipLocation = location;

        }

        public string GetDealershipName()
        {
            return this.DealershipName;
        }
        public string FormatString(string input)
        {
            string output = "";
            if (input.EndsWith("\n"))
            {
                output = input.Remove(input.Length - 2, 2);
            }
            return output.Replace("\n", "\n  ");
        }

        public override string ToString()
        {
            return FormatString(String.Format($"  Dealership Name: {this.DealershipName} \nLocation: {this.DealershipLocation}\n"));
        }
    }
}