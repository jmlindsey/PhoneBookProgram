using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    abstract class ASearch
    {
        public PhoneBook phoneBook;
        public String target;
        public List<Person> results;

        public ASearch(PhoneBook phoneBook, String target)
        {
            this.phoneBook = phoneBook;
            this.target = target;
            results = new List<Person>();
        }

        public abstract List<Person> Search(PhoneBook phoneBook);
    }
}
