using System;
using System.Collections.Generic;
using System.Text;

namespace Primtal
{
    public class Prime
    {
        private SortedSet<int> holdingList;

        public Prime()
        {
            holdingList = new SortedSet<int>();
        }

        public bool IsPrime(int number)
        {
            // Börjar på 1 för talet kommer alltid vara delbart med sig självt
            int count = 1;
            bool isPrime = false;
            // Loopar från 1 till 9 och om mängden delbara tal är större eller mindre än 2 så är det inte prime
            for (int i = 1; i < 10; i++)
            {
                //Skippar det talet man kollar för det är redan räknat
                if ((number != i) && (number % i == 0))
                {
                    count++;
                    if (count > 2)
                    {
                        break;
                    }
                }
            }

            // Kallar på AddPrime med talet och om det är prime
            isPrime = count == 2 ? true : false;
            AddPrime(number, isPrime);
            return isPrime;
        }

        // Lägger in ett tal om isPrime är true
        private void AddPrime(int number, bool isPrime)
        {
            if (isPrime)
            {
                holdingList.Add(number);
            }
        }

        // Skriver ut alla tal i konsolen
        public SortedSet<int> GetList()
        {
            return holdingList;
        }

        // Hämtar det högsta talet i holdingList eftersom det är sorterat och ökar det tills att det är prime
        public void GenerateNextPrime()
        {
            int number = holdingList.Max + 1;

            while (!IsPrime(number))
            {
                number++;
            }
        }
    }
}
