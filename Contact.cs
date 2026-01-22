using System;

namespace AddressBook.AddressBook
{
    internal class Contact
    {
        //fields
        public string? firstName;
        public string? lastName;
        public string? address;
        public string? city;

        public string? state;

        public int zip;

        public string? phone {get; set;}

        public string? email;

        //default constructor for user to enter the details in console.
        public Contact()
        {
            
        }

        //parameterized constructor for user to take the details from the user in constructor.
        public Contact(string firstName,string lastName,string address,string city,string state,int zip,string phone,string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phone = phone;
            this.email = email;
        }

        //user defined method to display contact details
        public void Display()
        {
            System.Console.WriteLine($"Person Name is: {firstName} {lastName}");
            System.Console.WriteLine($"Address: {address}");
            System.Console.WriteLine($"City: {city}");
            System.Console.WriteLine($"State: {state}");
            System.Console.WriteLine($"Pincode: {zip}");
            System.Console.WriteLine($"Phone: {phone}");
            System.Console.WriteLine($"Email: {email}");
            System.Console.WriteLine("------------");
        }
    }
}