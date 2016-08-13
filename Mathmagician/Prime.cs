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
            if (user_integer < 1) throw new ArgumentException("Must be a positive integer");
            if (user_integer == 1) return new List<int> { 2 };
            if (user_integer == 2) return new List<int> { 2, 3 };

            int numOfPrimes = user_integer; //converting user's input to numOfPrimes for readability

            int[] Primes = new int[numOfPrimes]; //establishes Primes array and allocates space for that many prime numbers
            Primes[0] = 2; //adding 2 as index[1] of int array Primes
            int currentPrimeIndex = 1; //setting the index for next Prime number to be stored in
            int numUnderTest = 3; //first number to check for "Primeness" was (3)

            while (user_integer > 0) //while loop will run until index is NOT 0 (each index assigned null(0) upon array initialization)
            {
                double halfOfNumUnderTest = numUnderTest / 2; //dividing number under test by 2
                int halfOfNumUnderTestRoundedDown = (int)Math.Floor(halfOfNumUnderTest); //rounding down quotient from halfOfNumUnderTest

                int[] numsToTest = new int[halfOfNumUnderTestRoundedDown]; //creating array nums to test with length halfOfNumUnderTest...
                for (int i = 0; i < halfOfNumUnderTestRoundedDown; i++) //for loop to create values to modulo numUnderTest by   //changed from numsToTest.length to halfOfNumUnderTestRoundedDown
                {                                                  // added {} this loop is working
                    numsToTest[i] = i + 1;
                }


                bool isPrime = true;  //setting isPrime bool to true for if statements 

                for (int i = 2; i < numsToTest.Length; i++) //for loop to modulus numUnderTest by each value in numsToTest array
                {
                    try
                    {
                        int j = numsToTest[i]; } catch
                    {
                        continue;
                    }
                    if (numUnderTest % numsToTest[i] == 0)
                    {
                        isPrime = false; //setting isPrime to false for any values that divide cleanly by any value in numsToTest array
                        currentPrimeIndex--;
                        break;

                    }                      // $$$#######  for 9, isPrime evaluates as false and sets Primes[4] to 0   ########$$$$$$
                    
                }
                if (isPrime == true)  //if statement for all numbers that have remainder from quotient of numUnderTest/numsToTest
                {
                    Primes[currentPrimeIndex] = numUnderTest; //setting the next index in our Prime array to numUnderTest which has passed all modulus test
                }
                user_integer--;
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
