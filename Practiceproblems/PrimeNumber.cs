using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practiceproblems
{
    internal class PrimeNumber
    {
        public void CheckprimeNo()
        {
            int flags=0;
            Console.Write("Enter The Number You Want to Check Prime Number or Not : ");
            int Number=Convert.ToInt32(Console.ReadLine());
          
             for (int i = 2; i<Number/2; i++)
            {
                if (Number % i == 0)
                {
                    flags = 1;
                    Console.WriteLine("The Number You Enter is a Prime Number");
                    return;
                }
                if(flags == 0)
                {
                    Console.WriteLine("The Number you Enter is not a Prime Number");
                }
            }
             
           

        }
    }
}
