using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeToBeTest
{
    public class NumChecker
    {
        public string CheckNum(int num)
        {
            if(num == 2)
            {
                return "PRIME";
            }
            else if (num % 2 == 0)
            {
                return "EVEN";
            }
            else
            {
                //Sieve of Erathones - clever way of find primes 

                for(int i = 3; i < num; i += 2)
                {
                    if(num % i == 0)
                    {
                        return "ODD";
                    }
                }

                return "PRIME";
            }
        }
    }
}
