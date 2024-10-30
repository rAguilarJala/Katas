using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataProject
{
    public class FindUniqueNumber
    {
        public static int GetUnique(IEnumerable<int> numbers)
        {
            return numbers.First(c => numbers.Count(x => x == c) == 1);
        }
    }
}
