using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Integer
    {
        public List<int> CreateIntegerSequence(int user_integer)
        {
            //throw new NotImplementedException();
            var outputList = new List<int>();
            for (int i = 0; i < user_integer; i++)
            {
                outputList.Add(i);
            }
            return outputList;
        } 
    }
}
