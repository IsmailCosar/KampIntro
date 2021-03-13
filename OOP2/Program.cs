using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            RealCustomer customer1 = new RealCustomer();
            customer1.CustomerNumber = "12345";
            customer1.FirstName = "İsmail";
            customer1.LastName = "Coşar";
            customer1.TcNumber = "12345678910";


            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.TaxNumber = "1234567890";
            customer2.CompanyName = "CSR";



            Customer customer3 = new CoorporateCustomer();
            Customer customer4 = new RealCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);



        }
    }
}
