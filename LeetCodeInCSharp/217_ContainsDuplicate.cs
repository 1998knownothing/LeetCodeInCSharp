﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class ContainsDuplicateSolution
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            var hashSet = new HashSet<int>();
            foreach (var num in nums)
            {
                if (hashSet.Add(num) == false)
                    return true;
            }
            return false;
        }
    }
}
