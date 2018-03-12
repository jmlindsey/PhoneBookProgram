using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Person
    {
        public String name;
        public Address address;
        public String telephone;


        public Person(String name, Address address, String telephone)
        {
            this.name = name;
            this.address = address;
            this.telephone = telephone;
        }

        public override String ToString()
        {
            return String.Format("{0}\n{1}\n{2}\n\n", name, address.ToString(), telephone);
        }

    }
}
