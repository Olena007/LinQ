using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventNLINQ.Models
{
    internal class LinQ
    {
        List<string> telBook = new List<string>() { "Abramov", "Grno", "Ubernicht", "Lambriex", "Afonya", "Ignat", "Abramov"};

        public void Start()
        {
            string first = telBook.FirstOrDefault();

            Console.WriteLine($"first element is {first}");
            var telBookLinq = from tel in telBook
                              where tel.StartsWith("A")
                              orderby tel
                              select tel;

            foreach (var tel in telBook)
            {
                Console.WriteLine(tel);
            }

            IEnumerable<string> list = telBook.Distinct();
            foreach (var tel in list)
            {
                Console.WriteLine(tel);
            }
        }
    }
}
