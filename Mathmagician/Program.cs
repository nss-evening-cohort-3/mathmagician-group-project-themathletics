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
            Fib fib = new Fib();
            Console.WriteLine(fib.CreateFibSequence(7));
        }
    }
}
