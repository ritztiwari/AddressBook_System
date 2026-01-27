using System;
using System.Diagnostics.Contracts;
using AddressBook.AddressBook;

namespace AddressBook.AddressBook
{
    internal class AddressBook
    {
        List<Contact> contacts;

        public AddressBook()
        {
            contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
            Console.WriteLine("Contact added successfully");
        }
        
        public void DisplayContacts()
        {
            System.Console.WriteLine("\n--------Address Book--------");
            foreach (Contact c in contacts)
            {
                c.Display();
            }
        }
    }
}