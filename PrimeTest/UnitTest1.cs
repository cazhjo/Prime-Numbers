using NUnit.Framework;
using Primtal;

namespace PrimeTest
{
    public class Tests
    {
        [Test]
        public void NumberIsPrime()
        {
            int number = 7;
            Prime prime = new Prime();
            Assert.IsTrue(prime.IsPrime(number));
        }

        [Test]
        public void NumberIsNotPrime()
        {
            int number = 4;
            Prime prime = new Prime();
            Assert.IsFalse(prime.IsPrime(number));
        }

        [Test]
        public void MaxNumberIsCorrect()
        {
            Prime prime = new Prime();
            prime.IsPrime(2);
            prime.IsPrime(3);
            prime.GenerateNextPrime();
            var temp = prime.GetList();

            Assert.IsTrue(temp.Max == 5);
        }
        [Test]
        public void CountOfNumbersAreCorrect()
        {
            Prime prime = new Prime();

            for (int i = 0; i <= 20; i++)
            {
                prime.IsPrime(i);
            }

            var temp = prime.GetList();
            Assert.IsTrue(temp.Count == 8);
        }

        [Test]
        public void ListIsEmpty()
        {
            Prime prime = new Prime();
            prime.IsPrime(1);
            prime.IsPrime(4);
            prime.IsPrime(6);
            prime.IsPrime(8);
            prime.IsPrime(9);
            prime.IsPrime(10);

            var temp = prime.GetList();

            Assert.IsTrue(temp.Count == 0);
        }
    }
}