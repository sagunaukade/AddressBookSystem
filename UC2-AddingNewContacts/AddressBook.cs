using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC2_AddingNewContacts
{
    internal class AddressBook
    {
        public static List<Person> People = new List<Person>();
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Addressess { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string PhoneNumber { get; set; }
            public string ZipCode { get; set; }
            public string Email { get; set; }

        }
        public static void GetPerson()
        {
            Person person = new Person();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Address : ");
            person.Addressess = Console.ReadLine();

            Console.Write("Enter City : ");
            person.City = Console.ReadLine();

            Console.Write("Enter State : ");
            person.State = Console.ReadLine();

            Console.Write("Enter ZipCode: ");
            person.ZipCode = Console.ReadLine();
            Console.Write("Enter ZipCode: ");
            person.Email = Console.ReadLine();
            People.Add(person);
        }
        public static void PrintCustomer(Person person)
        {
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Address : " + person.Addressess);
            Console.WriteLine("City : " + person.City);
            Console.WriteLine("State : " + person.State);
            Console.WriteLine("ZipCode : " + person.ZipCode);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("EmailId: " + person.Email);
            
        }
        public static void ListingPeople()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("Your address book is empty.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people in your address book:\n");
            foreach (var person in People)
            {
                PrintCustomer(person);
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
    }
}
