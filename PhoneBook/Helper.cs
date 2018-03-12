using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Helper
    {
        public static String Prompt(String promptWord)
        {
            Console.WriteLine("Enter {0}:", promptWord);
            return Console.ReadLine();
        }
        public static List<T> Filter<T, U>(List<T> list, Func<T, U> func)
        {
            List<T> results = new List<T>();
            foreach(T item in list)
                func(item);
            return results;
        }
    }
}
