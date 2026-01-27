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

        public void EditContact(string name)
        {
            Console.WriteLine("----updating the contact----");

            #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            Contact contact = contacts.Find(c => $"{c.firstName} {c.lastName}".Equals(name, StringComparison.OrdinalIgnoreCase));
            #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            if (contact != null)
            {
                Console.WriteLine($"{name} found. Updating details...");
                Edit(contact);
                Console.WriteLine("Contact details updated successfully.");
            }
            else
            {
                Console.WriteLine("This person contact is not available in address book.");
            }
        }

        public void Edit(Contact updated)
        {
            System.Console.WriteLine("Updating the details...");
            //Using Console to edit person details
            System.Console.WriteLine("Enter updated First name: ");
            updated.firstName = Console.ReadLine();
            System.Console.WriteLine("Enter updated Last name: ");
            updated.lastName = Console.ReadLine();
            System.Console.WriteLine("Enter updated Address: ");
            updated.address = Console.ReadLine();
            System.Console.WriteLine("Enter updated City: ");
            updated.city = Console.ReadLine();
            System.Console.WriteLine("Enter updated State name: ");
            updated.state = Console.ReadLine();
            System.Console.WriteLine("Enter updated Zip code: ");
            updated.zip = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter updated Phone: ");
            updated.phone = Console.ReadLine();
            System.Console.WriteLine("Enter updated Email: ");
            updated.email = Console.ReadLine();
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