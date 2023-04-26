using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Dealership_Demo
{
    public class Employees : Dealership
    {
        protected string EmployeeFName { get; set; }
        protected string EmployeeLName { get; set; }
        protected string EmployeeTitle { get; set; }
        private int EmployeeSalary { get; set; }

        public Employees()
        {

        }
        public Employees(string dealerShipName, string location, string fName, string lName, string title, int rate)
        {
            this.DealershipName = dealerShipName;
            this.DealershipLocation = location;
            this.EmployeeFName = fName;
            this.EmployeeLName = lName;
            this.EmployeeTitle = title;
            this.EmployeeSalary = CalculateSalary(title, rate);
        }

        private int CalculateSalary(string title, int rate)
        {
            if (title.StartsWith("C"))
            {
                return rate * 8 * 5 * 4 * 12 * 5;
            }
            else if (title.Contains("sales") || title.Contains("Sales"))
            {
                return rate * 8 * 5 * 4 * 12 * 2;
            }
            else
            {
                return rate * 8 * 5 * 4 * 12;
            }
        }

        public string GetEmployeeName()
        {
            return String.Format($"{this.EmployeeFName}-{this.EmployeeLName}");
        }

        public override string ToString()
        {
            return FormatString(String.Format($"  Name: {this.EmployeeFName} {this.EmployeeLName} \nTitle: {this.EmployeeTitle} \nLocation: {this.DealershipLocation} \nDealership Name: {this.DealershipName} \nSalary: {this.EmployeeSalary.ToString("C")}\n"));
        }
    }
}