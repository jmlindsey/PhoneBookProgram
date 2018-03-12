using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PhoneBook
{
    class PhoneBook
    {
        public List<Person> people;

        public PhoneBook() {
            people = new List<Person>();
        }

        public void Add()
        {
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
            people.Add(new Person(name, new Address(streetAddress, city, state, zipcode), telephone));
        }

        public void Add(String name, String streetAddress, String city, String state, String zipcode, String telephone)
        {
            people.Add(new Person(name, new Address(streetAddress, city, state, zipcode), telephone));
        }


        public Person Delete(String telephone)
        {
            List<Person> results = Search(new SearchTelephone(this, telephone));
            if (results.Count > 0)
            {
                people.Remove(results[0]);
                return results[0];
            }
            Console.WriteLine("Telephone number not found.  Delete failed");
            return null;
        }

        public Person Update(String telephone, String name)
        {
            List<Person> results = Search(new SearchTelephone(this, telephone));
            if (results.Count > 0)
            {
                results[0].name = name;
                return results[0];
            }
            Console.WriteLine("Telephone number not found.  Update failed");
            return null;
        }

        public String DisplayAll()
        {
            String outString = "\n";
            foreach(Person p in people)
                outString += p.ToString();
            return outString;
        }

        public List<Person> Search(ASearch search)
        {
            List<Person> results = new List<Person>();
            foreach (Person p in search.Search(this))
            {
                results.Add(p);
                Console.WriteLine(p);
            }
            if (results.Count() == 0) Console.WriteLine("No results found");
            return results;
        }

    }
}
