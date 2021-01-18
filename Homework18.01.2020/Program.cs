using System;

namespace Homework18._01._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 54652;
            customer1.NameSurname = "Kerem Burak Yılmaz";
            customer1.Age = 18;
            customer1.IsStudent = true;
            customer1.CreditCardNumber = 1111111111111111;

            Customer customer2 = new Customer();
            customer2.Id = 65798;
            customer2.NameSurname = "Güneş Arpa";
            customer2.Age = 16;
            customer2.IsStudent = true;
            customer2.CreditCardNumber = 2222222222222222;

            Customer customer3 = new Customer();
            customer3.Id = 13247;
            customer3.NameSurname = "Batuhan Kocabaş";
            customer3.Age = 17;
            customer3.IsStudent = true;
            customer3.CreditCardNumber = 3333333333333333;

            Customer customer4 = new Customer();
            customer4.Id = 58464;
            customer4.NameSurname = "Engin Demiroğ";
            customer4.Age = 35;
            customer4.IsStudent = false;
            customer4.CreditCardNumber = 4444444444444444;

            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer1);
            customerManager.ShowCustomer(customer2);
            customerManager.DeleteCustomer(customer3);
            customerManager.ShowCustomersClassifiedInfo(customer4);
        }
    }
}
