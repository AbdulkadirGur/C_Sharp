using System;

namespace Interfaces
    
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //Demo();
            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal()

            };
            foreach (ICustomerDal customerDal in customerDals)
            {
                customerDal.Add();
            }
            
            
            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Abdulkadir",
                LastName = "Gur",
                Adress = "Mersin"
            };
            manager.Add(customer);
            Student student = new Student
            {
                Id = 2,
                FirstName = "Unkknown",
                LastName = "knoew",
                Department = "Copmuter Sciense"
            };
            manager.Add(student);
        }
    }


    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string LastName { get; set; }
        public string? Adress { get; set; }

    }
    class Student : IPerson
    {

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }

    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}