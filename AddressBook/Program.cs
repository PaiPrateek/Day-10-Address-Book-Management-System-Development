using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size of the Address Book:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("\n                                        \n");

            Console.WriteLine("Size of the Address Book is :" + size);
            Console.WriteLine("...................................");
            Console.WriteLine("\n                                        \n");

            Console.WriteLine("Press Enter to Add the COntact in Address Book ");
            string Press = Console.ReadLine();

            AddressBook addressBook = new AddressBook(size);
            addressBook.AddNewContact();

            Console.WriteLine("The Details of the First Contact in Address Book is:");
            addressBook.PrintAllContact();
            Console.WriteLine("...................................");

            Console.WriteLine("Press 1 to Add Contact to address Book");
            int Input = int.Parse(Console.ReadLine());
            Console.WriteLine("...................................");

            if (Input==1)
            {
                addressBook.AddNewContact();
                Console.WriteLine("...................................");
                Console.WriteLine("Contact is Added to Address Book Successfylly");
            }
            else
            {
                Console.WriteLine("Enter Valid input");
            }
        }
    }
}
