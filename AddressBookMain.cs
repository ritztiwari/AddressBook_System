using System;

namespace AddressBook.AddressBook
{
    internal class AddressBookMain
    {
        internal static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");

            //taking the input from parameterised constructor.
            // Contact contact = new Contact("rishabh","tiwari","Block B","ghaziabad","uttar pradesh",201009,"4587695358","abc@gmail.com");

            // // displaying the contact details
            // contact.Display();

            AddressBook addressBook = new AddressBook(); // address book

            Contact contact = new Contact();
            // taking details from console
            System.Console.WriteLine("Enter first name: ");
            contact.firstName = Console.ReadLine();
            System.Console.WriteLine("Enter last name: ");
            contact.lastName = Console.ReadLine();
            System.Console.WriteLine("Enter Address: ");
            contact.address = Console.ReadLine();
            System.Console.WriteLine("Enter City: ");
            contact.city = Console.ReadLine();
            System.Console.WriteLine("Enter State name: ");
            contact.state = Console.ReadLine();
            System.Console.WriteLine("Enter Zip code: ");
            contact.zip = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Phone: ");
            contact.phone = Console.ReadLine();
            System.Console.WriteLine("Enter Email: ");
            contact.email = Console.ReadLine();

            addressBook.AddContact(contact);
            addressBook.DisplayContacts(); // displaying contacts

            string name = "rishabh tiwari";
            addressBook.EditContact(name);
        }
    }
}