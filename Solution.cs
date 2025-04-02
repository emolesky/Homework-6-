using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Removing
{
    class Solution
    {
        private int[] nums = [];
        private int val = 0;
        private int i;

        public int[] Nums
        {
            get { return this.Nums; }
            set {  this.Nums = value; }
        }
        public int Val
        {
            get { return this.Val; }
            set {this.Val = value; }
        }

        public Solution(int[] nums, int val)
        {
            this.Nums= nums;
            this.Val = val;

        }

        public int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            

            for (int i = 0; i < nums.Length; i++);
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }
    }
}
