using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC2_AddingNewContacts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book System");
            Console.ReadLine();
            UC2_AddingNewContacts.AddressBook.GetPerson();

            UC2_AddingNewContacts.AddressBook.ListingPeople();

        }
    }
}
