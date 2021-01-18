using System;
using System.Collections.Generic;
using System.Text;

namespace Homework18._01._2020
{
    class CustomerManager
    {
        public void AddCustomer (Customer customer)
        {
            Console.WriteLine("Customer named " + customer.NameSurname + " is added");
            Console.WriteLine("\n---------------------------------------------\n");
        }

        public void ShowCustomer (Customer customer)
        {
            Console.WriteLine("Customer's name: " + customer.NameSurname);
            Console.WriteLine("Customer's age: " + customer.Age);
            Console.WriteLine(customer.IsStudent ? "Customer is a student" : "Customer is not a student");
            Console.WriteLine("\n---------------------------------------------\n");
        }
        
        public void DeleteCustomer (Customer customer)
        {
            Console.WriteLine("Customer named " + customer.NameSurname + " is deleted");
            Console.WriteLine("\n---------------------------------------------\n");
        }

        public void ShowCustomersClassifiedInfo (Customer customer)
        {
            Console.WriteLine("-------------- CLASSIFIED INFO --------------\n");
            Console.WriteLine("Customer's Id: " + customer.Id);
            Console.WriteLine("Customer's Credit Card Number: " + customer.CreditCardNumber);
            Console.WriteLine("\n-------------- CLASSIFIED INFO --------------\n");
        }
    }
}
