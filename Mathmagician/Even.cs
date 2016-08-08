using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class Even
    {
        public List<int> CreateEvenSequence(int user_integer)
        {
            List<int> evensList = new List<int>();
            for (int i = 0; i < user_integer; i++)
            {
                evensList.Add(i + i);
            }
            return evensList;
        }


    }
}
