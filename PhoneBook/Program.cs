using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static List<A> give<A,U>(List<U> list)
        {
            List<A> results = new List<A>();
            foreach (U item in list)
                results.Add((A)Convert.ChangeType(item, typeof(A)));
            return new List<A>();
        }
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();

            // for testing purposes only
            phoneBook.Add("John Doe", "114 Market St", "St Louis", "MO", "63403", "6366435698");
            phoneBook.Add("John E Doe", "324 Main St", "St Charles", "MO", "63303", "8475390126");
            phoneBook.Add("John Michael West Doe", "574 Pole ave", "St Peters", "MO", "63333", "5628592375"); 

            new Player().Play(phoneBook);
            List<Person> people = new List<Person>();
            Helper.Filter(people, (p) => p.name = "Bob");
            foreach (Person p in people)
                Console.WriteLine(p.name);

            Console.ReadLine();
        }
    }
}
