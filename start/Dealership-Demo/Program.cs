using System.Collections;
using System.Collections.Generic;

namespace Dealership_Demo
{
    class Program
    {
        public static void Main(string[] args)
        {

            Hashtable ht = new Hashtable();
            Dealership myDealership = new Dealership("Toyota of Nash", "Nashville, TN");
            ht.Add(myDealership.GetDealershipName(), myDealership);

            Employees emp1 = new Employees("Toyota of Nash", "Nashville, TN", "Mihir", "Patel", "CEO", 50);
            Employees emp2 = new Employees("Toyota of Nash", "Nashville, TN", "Josh", "kramer", "Sales Manager", 30);
            Employees emp3 = new Employees("Toyota of Nash", "Nashville, TN", "Saurabh", "Kansara", "COO", 40);

            ht.Add(emp1.GetEmployeeName(), emp1);
            ht.Add(emp2.GetEmployeeName(), emp2);
            ht.Add(emp3.GetEmployeeName(), emp3);

            Customer customer1 = new Customer("Jimmy", "Lane", "jimmy.lane@gmail.com", "1234567890", "Nashville, TN");
            Customer customer2 = new Customer("Jason", "Moore", "jason.Moore@gmail.com", "3214567890", "Nashville, TN");
            Customer customer3 = new Customer("John", "Mike", "john.Mike@gmail.com", "2134567890", "Nashville, TN");
            Customer customer4 = new Customer("Jack", "Larry", "Jack.Larry@gmail.com", "1124567890", "Nashville, TN");
            Queue<Customer> customerQueue = new Queue<Customer>();
            customerQueue.Enqueue(customer1);
            customerQueue.Enqueue(customer2);
            customerQueue.Enqueue(customer3);
            customerQueue.Enqueue(customer4);

            customerQueue.Dequeue(); // Removes Jimmy lane from the Queue
            Console.WriteLine($"Custer in Queue is: \n{customerQueue.Peek()}");

            ht.Add(customer1.GetCustomerEmail(), customer1);
            ht.Add(customer2.GetCustomerEmail(), customer2);
            ht.Add(customer3.GetCustomerEmail(), customer3);
            ht.Add(customer4.GetCustomerEmail(), customer4);

            foreach (DictionaryEntry value in ht)
            {
                Console.WriteLine($"{value.Key} :");
                Console.Write("{\n");
                Console.WriteLine($"{value.Value}");
                Console.WriteLine("}");
            }

        }
    }
}
