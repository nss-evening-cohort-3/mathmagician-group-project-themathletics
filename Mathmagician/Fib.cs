using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Fib
    {
        public List<int> CreateFibSequence(int user_input)
        
        {
            List<int> outputList = new List<int> {1, 1};
            for (int i = 2; i < user_input; i++)
            {
                outputList.Add(outputList.ElementAt(i - 2) + outputList.ElementAt(i - 1));
            }
            return outputList;
        } 
    }
}
