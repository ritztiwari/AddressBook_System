using System;

namespace AddressBook.AddressBook
{
    internal class AddressBookMain
    {
        internal static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");

            //taking the input from parameterised constructor.
            Contact contact = new Contact("rishabh","tiwari","Block B","ghaziabad","uttar pradesh",201009,"4587695358","abc@gmail.com");

            // displaying the contact details
            contact.Display();
        }
    }
}