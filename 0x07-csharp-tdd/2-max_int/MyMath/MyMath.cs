using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>This class contains operations.</summary>
    public class Operations
    {
        /// <summary>This method gets the maximun integer in a list.</summary>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
                return 0;
            int max = nums[0];
            
            foreach (int element in nums)
            {
                if (element > max)
                    max = element;
            }
            
            return max;
        }
    }
}
