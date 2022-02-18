﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC6_UniqueName
{
    internal class Contacts
    {
        public string adBkName;
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public long zipCode;
        public long phoneNumber;
        public string email;

        public Contacts(string adBkName, string firstName, string lastName, string address, string city, string state, long zipCode, long phoneNumber, string email)
        {
            this.adBkName = adBkName;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public void Display()
        {
            Console.WriteLine("Address Book Name:{0}", this.adBkName);
            Console.WriteLine("First Name:{0}", this.firstName);
            Console.WriteLine("Last Name:{0}", this.lastName);
            Console.WriteLine("Address:{0}", this.address);
            Console.WriteLine("City: {0}", this.city);
            Console.WriteLine("State:{0}", this.state);
            Console.WriteLine("Zipcode:{0}", this.zipCode);
            Console.WriteLine("phone number:{0}", this.phoneNumber);
            Console.WriteLine("Email:{0}", this.email + "\n");
        }

    }
}