using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Player
    {
        public Player() { }

        public void Play(PhoneBook phoneBook)
        {
            Console.WriteLine("Phone Book");
            Boolean run = true;

            while (run)
            {
                Console.WriteLine("1. Add " +
                    "\n2. Search " +
                    "\n3. Update " +
                    "\n4. Delete " +
                    "\n5. Display all contacts" +
                    "\n6. Exit\n");

                switch (Console.ReadLine())
                {
                    case "1": //Add
                        Console.WriteLine("Add...");
                        Console.WriteLine("Enter full name: ");
                        String name = Console.ReadLine();
                        Console.WriteLine("Enter street address (ex. 123 Fake St.): ");
                        String streetAddress = Console.ReadLine();
                        Console.WriteLine("Enter city: ");
                        String city = Console.ReadLine();
                        Console.WriteLine("Enter state abbreviation (ex. IL): ");
                        String state = Console.ReadLine();
                        Console.WriteLine("Enter zipcode: ");
                        String zipcode = Console.ReadLine();
                        Console.WriteLine("Enter telephone (1234567890): ");
                        String telephone = Console.ReadLine();
                        phoneBook.Add(name, streetAddress, city, state, zipcode, telephone);
                        break;

                    case "2": //Search
                        Boolean stayHere = true;

                        while (stayHere)
                        {
                            Console.WriteLine("Search...");
                            Console.WriteLine("1. Search by first name "
                                + "\n2. Search by last name "
                                + "\n3. Search by full name (first last)"
                                + "\n4. Search by telephone number (xxx-xxx-xxxx)"
                                + "\n5. Search by city"
                                + "\n6. Search by state"
                                + "\n7. go back");

                            switch (Console.ReadLine())
                            {
                                case "1":
                                    phoneBook.Search(new SearchFirst(phoneBook, Helper.Prompt("first name")));
                                    break;
                                case "2":
                                    phoneBook.Search(new SearchLast(phoneBook, Helper.Prompt("last name")));
                                    break;
                                case "3":
                                    phoneBook.Search(new SearchFullName(phoneBook, Helper.Prompt("full name")));
                                    break;
                                case "4":
                                    phoneBook.Search(new SearchTelephone(phoneBook, Helper.Prompt("telephone number(xxx - xxx - xxxx")));
                                    break;
                                case "5":
                                    phoneBook.Search(new SearchCity(phoneBook, Helper.Prompt("city")));
                                    break;
                                case "6":
                                    phoneBook.Search(new SearchState(phoneBook, Helper.Prompt("state")));
                                    break;
                                case "7":
                                    stayHere = false;
                                    break;
                                default:
                                    Console.WriteLine("Invalid selection...");
                                    continue;
                            }
                        }
                        break;

                    case "3": //Update
                        Console.WriteLine("Update...");
                        Console.WriteLine("Enter telephone of contact to update");
                        String number = Console.ReadLine();
                        Console.WriteLine("Enter new name for contact");
                        String newName = Console.ReadLine();
                        Person toUpdate = phoneBook.Update(number, newName);
                        if (toUpdate != null)
                            Console.WriteLine("Changed contact with phone number {0}'s name to {1}...", number, toUpdate.name);
                        else
                            Console.WriteLine("number not found...");
                        break;

                    case "4": //Delete
                        Console.WriteLine("Delete...");
                        Console.WriteLine("Enter telephone number of contact to delete");
                        number = Console.ReadLine();
                        Person toDelete = phoneBook.Delete(number);
                        if ( toDelete != null)
                            Console.WriteLine("Deleted contact {0} with phone number {1}...", toDelete.name, number);
                        else
                            Console.WriteLine("number not found...");
                        break;

                    case "5": //Display all
                        Console.WriteLine(phoneBook.DisplayAll());
                        break;

                    case "6": //Exit
                        Console.WriteLine("Exiting...");
                        run = false;
                        break;

                    default: //Invalid entry
                        Console.WriteLine("Invalid choice.  Please make another selection...");
                        break;
                }
            }
        }
    }
}
