using EventNLINQ.Models;
using System;

namespace EventNLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sum = new Sum();

            sum.SumEvent += sum.sumh;

            sum.SumMethods(sum.sumh);


        }
    }
}
