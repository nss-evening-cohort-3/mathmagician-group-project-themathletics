using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Prime
    {
        public List<int> CreatePrimeSequence(int user_integer)
        {

            int numOfPrimes = user_integer; //converting user's input to numOfPrimes for readability

            int[] Primes = new int[numOfPrimes]; //establishes Primes array and allocates space for that many prime numbers
            Primes[0] = 2; //adding 2 as index[1] of int array Primes
            int currentPrimeIndex = 1; //setting the index for next Prime number to be stored in
            int numUnderTest = 3; //first number to check for "Primeness" was (3)

            while (Primes[Primes.Length - 1] != Primes.Length ) //while loop will run until (?)
            {
                double halfOfNumUnderTest = numUnderTest / 2; //dividing number under test by 2
                int halfOfNumUnderTestRoundedDown = (int)Math.Floor(halfOfNumUnderTest); //rounding down quotient from halfOfNumUnderTest

                int[] numsToTest = new int[halfOfNumUnderTestRoundedDown]; //creating array nums to test with length halfOfNumUnderTest...
                for (int i = 0; i < halfOfNumUnderTestRoundedDown; i++) //for loop to create values to modulo numUnderTest by   //changed from numsToTest.length to halfOfNumUnderTestRoundedDown
                {                                                  // added {} this loop is working
                    numsToTest[i] = i + 1;
                } 

                for (int i = 2; i < numsToTest.Length; i++)
                {
                    bool isPrime = true;
                    if (numUnderTest % numsToTest[i] == 0)
                    {
                        isPrime = false;
                    }
                    if (isPrime)
                    {
                        Primes[currentPrimeIndex] = numUnderTest;
                    }
                }

                numUnderTest += 2; //incrementing by two to reach next odd number for testing
                currentPrimeIndex++; //incrementing to set next the index which the next Prime number will be set under
            }


            //List<int> confirmedPrimesList = new List<int> { 2 };
            //for (int i = 3; i < user_integer; i += 2) //if statement to handle if user chooses 1,2,3
            //{
            //    double halfOfI = (i / 2);
            //    int halfOfIRoundedDown = (int)Math.Floor(halfOfI);


            //    foreach (int alreadyValidatedPrime in confirmedPrimesList)
            //    {
            //        int primeToModulusCurrentNumberWith = alreadyValidatedPrime;

            //        if (halfOfIRoundedDown % primeToModulusCurrentNumberWith == 1)
            //        {
            //            confirmedPrimesList.Add(i);
            //        }


            //    }


            //}
            return Primes.ToList();
        }
    }
}
