using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {   //get 7th prime
            int num = GetPrime(10001);
            Console.WriteLine(num);
            Console.ReadLine();
        }
        public static int GetPrime(int PrimeCount)
        {
            int count = 2; //2 and 3 are prime
            int start = 4;
            bool isPrime;
            while (count < PrimeCount)
            {
                isPrime = true;
                for (int i = 2; i < start; i++)
                {
                    if (start % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) count++;
                if (count == PrimeCount)
                {
                    return start;
                }
                start++;
            }

            return 0;
        }
    }
        }
 

