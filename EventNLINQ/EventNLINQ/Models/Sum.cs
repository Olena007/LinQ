using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventNLINQ.Models
{
    internal class Sum
    {
        public delegate int SumHandler(int a, int b);

        public SumHandler sumh;

        public event SumHandler SumEvent;

        public Sum()
        {
            sumh = SumNum;
        }

        public int SumNum(int a, int b) => a + b;

        public void SumMethods(SumHandler handler)
        {
            try
            {
                int sum = SumEvent.Invoke(SumNum(2,2), SumNum(3,3));

                Console.WriteLine(sum);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
