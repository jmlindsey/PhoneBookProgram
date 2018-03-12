using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class SearchCity : ASearch
    {
        public SearchCity(PhoneBook phoneBook, String target) : base(phoneBook, target) { }

        public override List<Person> Search(PhoneBook phoneBook)
        {
            foreach (Person person in phoneBook.people)
                if (person.address.city == target)
                    results.Add(person);
            return results;
        }
    }
}
