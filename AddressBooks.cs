using System;

namespace AddressBook.AddressBook
{
    internal class AddressBooks
    {
        Dictionary<string,AddressBook> directory = new Dictionary<string, AddressBook>();

        // method to add new address book
        public void AddAddressBook(string name)
        {
            if (directory.ContainsKey(name))
            {
                System.Console.WriteLine("Address book already exists with this name. \nTry with diffrent one");
                return;
            }
            directory[name] = new AddressBook();
            Console.WriteLine($"Address Book '{name}' created successfully.");
        }        
        
        public AddressBook GetAddressBook(string name)
        {
            if (directory.ContainsKey(name))
            {
                return directory[name];
            }
            else
            {
                Console.WriteLine("Address Book not found.");
                return null;
            }
        }

        // UC-08: Search persons by city across address books
        public List<Contact> SearchPersonByCity(string city)
        {
            List<Contact> result = new List<Contact>();
            foreach (var book in directory.Values)
            {
                result.AddRange(book.SearchByCity(city));
            }
            return result;
        }

        // UC-08: Search persons by state across address books
        public List<Contact> SearchPersonByState(string state)
        {
            List<Contact> result = new List<Contact>();
            foreach (var book in directory.Values)
            {
                result.AddRange(book.SearchByState(state));
            }
            return result;
        }

        // method to display all address books name
        public void DisplayAddressBooks()
        {
            Console.WriteLine("\nAvailable Address Books in the system:");
            foreach (var name in directory.Keys)
            {
                Console.WriteLine($"- {name}");
            }
        }
    }
}