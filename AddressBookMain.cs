using System;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Security.AccessControl;
using System.Xml.Serialization;

namespace AddressBook.AddressBook
{
    internal class AddressBookMain
    {
        internal static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");

            //uc-2
            //taking the input from parameterised constructor.
            // Contact contact = new Contact("rishabh","tiwari","Block B","ghaziabad","uttar pradesh",201009,"4587695358","abc@gmail.com");

            // // displaying the contact details
            // contact.Display();

            // AddressBook addressBook = new AddressBook(); // address book

            // Contact contact = new Contact();
            // // taking details from console
            // System.Console.WriteLine("Enter first name: ");
            // contact.firstName = Console.ReadLine();
            // System.Console.WriteLine("Enter last name: ");
            // contact.lastName = Console.ReadLine();
            // System.Console.WriteLine("Enter Address: ");
            // contact.address = Console.ReadLine();
            // System.Console.WriteLine("Enter city: ");
            // contact.city = Console.ReadLine();
            // System.Console.WriteLine("Enter State name: ");
            // contact.state = Console.ReadLine();
            // System.Console.WriteLine("Enter Zip code: ");
            // contact.zip = Convert.ToInt32(Console.ReadLine());
            // System.Console.WriteLine("Enter Phone: ");
            // contact.phone = Console.ReadLine();
            // System.Console.WriteLine("Enter Email: ");
            // contact.email = Console.ReadLine();

            // addressBook.AddContact(contact);
            // addressBook.DisplayContacts(); // displaying contacts

            //uc-3 modifying the existing person details.
            // string name = "rishabh tiwari";
            // addressBook.EditContact(name);
            // addressBook.EditContact(name);

            //uc-4 deleting the existing person details.
            // string name = "rishabh tiwari";
            // addressBook.EditContact(name);
            // addressBook.EditContact(name);

            //uc-5 
            // AddressBook addressBook = new AddressBook();
            // bool addMore = true;

            // while (addMore)
            // {
            //     Contact contact = new Contact();
            //     // taking details from console
            //     System.Console.WriteLine("Enter first name: ");
            //     contact.firstName = Console.ReadLine();
            //     System.Console.WriteLine("Enter last name: ");
            //     contact.lastName = Console.ReadLine();
            //     System.Console.WriteLine("Enter Address: ");
            //     contact.address = Console.ReadLine();
            //     System.Console.WriteLine("Enter City: ");
            //     contact.city = Console.ReadLine();
            //     System.Console.WriteLine("Enter State name: ");
            //     contact.state = Console.ReadLine();
            //     System.Console.WriteLine("Enter Zip code: ");
            //     contact.zip = Convert.ToInt32(Console.ReadLine());
            //     System.Console.WriteLine("Enter Phone: ");
            //     contact.phone = Console.ReadLine();
            //     System.Console.WriteLine("Enter Email: ");
            //     contact.email = Console.ReadLine();

            //     addressBook.AddContact(contact);

            //     System.Console.WriteLine("would you like to add more contact details if yes/no");
            //     string choice = Console.ReadLine();
            //     addMore = choice.Equals("yes");
            // }

            // addressBook.DisplayContacts();

            //uc-06 adding multiple address books.
            // Dictionary<string,AddressBook> directory = new Dictionary<string, AddressBook>();
            // AddressBook addressBook = new AddressBook();
        //     bool addAddressBooks = true;

        //     while(addAddressBooks)
        //     {
        //         System.Console.WriteLine("enter the address book name");
        //         string name = Console.ReadLine();

        //         if (directory.ContainsKey(name))
        //         {
        //             System.Console.WriteLine("AddressBook already exists.");
        //         }
        //         else
        //         {
        //             AddressBook addressbook = new AddressBook();
        //             directory.Add(name,addressbook);
        //             System.Console.WriteLine("AddressBook created successfully");
        //         }

        //         System.Console.WriteLine("Do you want to create another the address book if yes/no");
        //         string choice = Console.ReadLine();
        //         addAddressBooks = choice.Equals("yes");
        //     }

        //     bool AddContactsInAddressBook = true;
        //     while (AddContactsInAddressBook)
        //     {
        //         System.Console.WriteLine("enter the AddressBook to add contacts in it");
        //         string name = Console.ReadLine();

        //         if (directory.ContainsKey(name))
        //         {
        //             Contact contact = new Contact();

        //             System.Console.WriteLine("Enter first name: ");
        //             contact.firstName = Console.ReadLine();
        //             System.Console.WriteLine("Enter last name: ");
        //             contact.lastName = Console.ReadLine();
        //             System.Console.WriteLine("Enter Address: ");
        //             contact.address = Console.ReadLine();
        //             System.Console.WriteLine("Enter City: ");
        //             contact.city = Console.ReadLine();
        //             System.Console.WriteLine("Enter State name: ");
        //             contact.state = Console.ReadLine();
        //             System.Console.WriteLine("Enter Zip code: ");
        //             contact.zip = Convert.ToInt32(Console.ReadLine());
        //             System.Console.WriteLine("Enter Phone: ");
        //             contact.phone = Console.ReadLine();
        //             System.Console.WriteLine("Enter Email: ");
        //             contact.email = Console.ReadLine();

        //             directory[name].AddContact(contact);

        //             directory[name].DisplayContacts();

        //             System.Console.WriteLine("Do you want to add another contact details if yes/no.");
        //             string choice = Console.ReadLine();
        //             AddContactsInAddressBook = choice.Equals("yes");
        //         }
        //         else
        //         {
        //             System.Console.WriteLine($"address book name {name} doesn't exists");
        //             break;
        //         }
        //     }
        // }


        // uc-07 ensuring their is no duplicate contact details in any addressbook.
        
        // AddressBook addressBook = new AddressBook();
        //     Contact contact1 = new Contact
        //     {
        //         firstName = "Prashant",
        //         lastName = "Varshney",
        //         address = "123 Main",
        //         city = "CityA",
        //         state = "StateA",
        //         zip = 12345,
        //         phone = "123-456-7890",
        //         email = "prashant.varshney@example.com"
        //     };
        //     addressBook.AddContact(contact1);
        //     // Attempting to add duplicate contact
        //     Contact contact2 = new Contact
        //     {
        //         firstName = "Prashant",
        //         lastName = "Varshney",
        //         address = "456 Elm",
        //         city = "CityB",
        //         state = "StateB",
        //         zip = 67890,
        //         phone = "098-765-4321",
        //         email = "pc@gmail.com",
        //     };
        //     addressBook.AddContact(contact2); // adding duplicate

        // UC-08: Search persons by city or state across address books
            AddressBooks system = new AddressBooks();
            system.AddAddressBook("dost");
            system.AddAddressBook("Family");
            // Adding contacts to Friends Address Book
            var friendsBook = system.GetAddressBook("dost");
            friendsBook.AddContact(new Contact
            {
                firstName = "Uday",
                lastName = "Gupta",
                city = "Agra",
                state = "Uttar Pradesh"
            });
            friendsBook.AddContact(new Contact
            {
                firstName = "Arjun",
                lastName = "Chauhan",
                city = "Delhi",
                state = "Delhi"
            });
            // Adding contacts to Family Address Book
            var familyBook = system.GetAddressBook("Family");
            familyBook.AddContact(new Contact
            {
                firstName = "Hardik",
                lastName = "Varshney",
                city = "Greator Noida",
                state = "Uttar Pradesh"
            });

            familyBook.AddContact(new Contact
            {
                firstName = "Rishabh",
                lastName = "Tiwari",
                city = "Ghaziabad",
                state = "UP"
            });
            // Searching persons by city
            string searchCity = "Agra";
            var personInCity = system.SearchPersonByCity(searchCity);
            Console.WriteLine($"\nPersons in city '{searchCity}':");
            foreach (var person in personInCity)
            {
                System.Console.WriteLine($"- {person.firstName} {person.lastName} ({person.city}, {person.state})");
            }
            // Searching persons by state
            string searchState = "Uttar Pradesh";
            var personInState = system.SearchPersonByState(searchState);
            Console.WriteLine($"\nPersons in state '{searchState}':");
            foreach (var person in personInState)
            {
                System.Console.WriteLine($"- {person.firstName} {person.lastName} ({person.city}, {person.state})");
            }





        }
    }
}