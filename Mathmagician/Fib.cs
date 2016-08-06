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
            List<int> outputList = new List<int> {0};
            for (int i = 0; i < user_input; i++)
            {
                outputList.Add(i+outputList.IndexOf(user_input-1));
            }
            return outputList;
        } 
    }
}
