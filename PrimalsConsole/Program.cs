using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimalsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prime = new Program();
            prime.calculatePrimals(3, 30);

            Console.WriteLine(prime);
            Console.ReadLine();

        }


            private bool enableCalculating = true; // flaga sterująca uruchomieniem algorytmu
        private List<int> primals = new List<int>(); // lista przechowująca wygenerowane liczby

        public void calculatePrimals(int startNumber, int seconds)
        {
            Console.WriteLine("Calculator primals started from: " + startNumber);
            DateTime endPeriod = DateTime.Now.AddSeconds(seconds);
            var number = startNumber;
            while (DateTime.Now < endPeriod && enableCalculating)
            {
                if (IsPrime(number))
                {
                    Console.WriteLine("Found primal " + number);
                    primals.Add(number);
                }
                number = number + 2;
            }
        }

        private bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }
            if (number % 2 == 0)
            {
                return false;
            }
           
            var boundary = (int)Math.Floor(Math.Sqrt(number));
            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
           
        }
    }

}
   