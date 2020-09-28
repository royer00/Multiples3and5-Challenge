using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3and5
{
    class Program
    {
        static void Main(string[] args)
        {
            //global counter
            int total = 0;
            
            //check every number below 1000
            for (int i = 0; i < 1000; i++)
            {
                //find the multiples of 3 and 5
                if (i % 3 == 0 || i % 5 == 0)
                {
                    //add those to counter
                    total += i;
                }
            }
            Console.WriteLine(total);

        }
    }
}
