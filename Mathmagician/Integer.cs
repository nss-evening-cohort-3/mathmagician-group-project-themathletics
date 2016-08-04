using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Integer
    {
        public List<int> FinalOutPutInteger(int user_integer)
        {
            //throw new NotImplementedException();
            var output = new List<int>();
            for (int i = 0; i < user_integer; i++)
            {
                output.Add(i);
            }
            return output;
            // Console.WriteLine(); THIS NEEDS TO GO TO PROGRAM
        } 
    }
}
