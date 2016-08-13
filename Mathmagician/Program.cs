using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathmagician;

namespace Mathmagician
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like for me to do?");
            String user_command = Console.ReadLine().ToLower();
            Console.WriteLine("How many should I print?");
            string user_number_input = Console.ReadLine();
            Console.WriteLine();
            int user_number;
            if (int.TryParse(user_number_input, out user_number) && user_number > 1)
            {
                if (user_command == "integer")
                {
                    Integer user_integers = new Integer();
                    int int_To_Use = user_number;
                    var integer_output = user_integers.CreateIntegerSequence(int_To_Use);
                    foreach (int number in integer_output)
                    {
                        Console.WriteLine(number + " ");
                    }

                }
                else if (user_command == "even")
                {
                    Even user_evens = new Even();
                    int int_To_Use = user_number;
                    var even_output = user_evens.CreateEvenSequence(int_To_Use);
                    foreach (int number in even_output)
                    {
                        Console.WriteLine(number + " ");
                    }

                }
                else if (user_command == "odd")
                {
                    Odd user_odds = new Odd();
                    int int_To_Use = user_number;
                    var odd_output = user_odds.CreateOddSequence(int_To_Use);
                    foreach (int number in odd_output)
                    {
                        Console.WriteLine(number + " ");
                    }

                }
                else if (user_command == "fibonacci")
                {
                    Fib user_fibs = new Fib();
                    int int_To_Use = user_number;
                    var fib_output = user_fibs.CreateFibSequence(int_To_Use);
                    foreach (int number in fib_output)
                    {
                        Console.WriteLine(number + " ");
                    }

                }
                else if (user_command == "prime")
                {
                    Prime user_primes = new Prime();
                    int int_To_Use = user_number;
                    var prime_output = user_primes.CreatePrimeSequence(int_To_Use);
                    foreach (int number in prime_output)
                    {
                        Console.WriteLine(number + " ");
                    }

                }
                else
                {
                    Console.WriteLine("Please enter: Integer, Even, Odd, Fibonacci, or Prime");
                }




                Console.WriteLine();
                Console.WriteLine("Check it out, I printed " + user_number + " " + user_command + " numbers.");

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Please enter a valid number greater than 0");
            }
            


            
        }

    }
}
