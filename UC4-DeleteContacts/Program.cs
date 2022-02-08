using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC4_DeleteContacts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book System");
            Console.ReadLine();
            UC4_DeleteContacts.AddressBook.RemovePeople();
            UC4_DeleteContacts.AddressBook.GetCustomer();
            UC4_DeleteContacts.AddressBook.ListingPeople();
            //UC4_DeleteContacts.AddressBook.PrintCustomer();

        }
    }
}
