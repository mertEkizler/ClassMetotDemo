using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void CustomerAdd(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi : " + customer.Id + " - " + customer.FirstName + " - " + customer.LastName + " - " + customer.Age);
            Console.WriteLine("++++++++++++++++++++++++-");
        }
        public void CustomerDelete(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi : " + customer.Id + " - " + customer.FirstName + " - " + customer.LastName + " - " + customer.Age);
            Console.WriteLine("++++++++++++++++++++++++-");
        }
        public void CustomerList(Customer customer)
        {
            Console.WriteLine("Müşteri Listelesi");
            Console.WriteLine("Müşteri Id : " + customer.Id);
            Console.WriteLine("Müşteri Ad Soyad : " + customer.FirstName + " " + customer.LastName);
            Console.WriteLine("Müsteri Yaş : " + customer.Age);
        }
        
    }
}
