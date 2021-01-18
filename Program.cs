using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Mert";
            customer1.LastName = "Ekizler";
            customer1.Age = 25;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Sinan";
            customer2.LastName = "Taşkınlar";
            customer2.Age = 25;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Emre";
            customer3.LastName = "Çetin";
            customer3.Age = 25;

            Customer[] customer = new Customer[]
            {
                customer1, customer2, customer3
            };

            CustomerManager customerManager = new CustomerManager();
            customerManager.CustomerList(customer1);

            customerManager.CustomerAdd(customer2);

            customerManager.CustomerDelete(customer3);

            foreach (var x in customer)
            {
                Console.WriteLine(x.Id + " " + x.FirstName + " " + x.LastName + " " + x.Age);
            }

        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }
}
