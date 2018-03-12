using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class SearchState : ASearch
    {
        public SearchState(PhoneBook phoneBook, String target) : base(phoneBook, target) { }

        public override List<Person> Search(PhoneBook phoneBook)
        {
            foreach (Person person in phoneBook.people)
                if (person.address.state == target)
                    results.Add(person);
            return results;
        }
    }
}