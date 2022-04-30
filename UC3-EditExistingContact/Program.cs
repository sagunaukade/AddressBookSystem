using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC3_EditExistingContact
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book System");
            Console.ReadLine();
            UC3_EditExistingContact.AddressBook.GetCustomer();
            UC3_EditExistingContact.AddressBook.ListingPeople();

        }
    }
}
