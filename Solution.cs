using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class Solution
    {
        public int[] SortArrayByParity (int[] nums)
        {
            return nums.OrderBy(n => n % 2 ).ToArray();   
        }
    }
}
