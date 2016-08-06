using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Odd
    {
        public List<int> CreateOddSequence(int user_input)
        {
            List<int> outputList = new List<int>();
            for (int i = 0; i < user_input; i++)
            {
                outputList.Add(i+i+1);
            }
            return outputList;
        } 
    }
}
