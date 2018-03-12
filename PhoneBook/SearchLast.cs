using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class SearchLast : ASearch
    {
        public SearchLast(PhoneBook phoneBook, String target) : base(phoneBook, target) { }

        public override List<Person> Search(PhoneBook phoneBook)
        {
            foreach (Person person in phoneBook.people)
            {
                String[] names = person.name.Split();
                if (names[names.Length-1] == target)
                    results.Add(person);
            }
            return results;
        }
    }
}
