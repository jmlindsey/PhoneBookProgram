using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Address
    {
        public String streetAddress;
        public String city;
        public String state;
        public String zipcode;

        public Address(String streetAddress, String city, String state, String zipcode)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.state = state;
            this.zipcode = zipcode;
        }

        public override String ToString()
        {
            return String.Format("{0} \n {1}, {2} {3}", streetAddress, city, state, zipcode);
        }

    }
}
