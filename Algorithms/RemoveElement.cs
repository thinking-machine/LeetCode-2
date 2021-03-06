// Source : https://leetcode.com/problems/remove-element/ 
// Author : codeyu 
// Date : Thursday, October 13, 2016 10:42:52 PM 

/**********************************************************************************
*
* Given an array and a value, remove all instances of that value in place and return the new length.
* 
* 
* Do not allocate extra space for another array, you must do this in place with constant memory.
* 
* The order of elements can be changed. It doesn't matter what you leave beyond the new length.
* 
* 
* Example:
* Given input array nums = [3,2,2,3], val = 3
* 
* 
* Your function should return length = 2, with the first two elements of nums being 2.
* 
* 
*   Try two pointers.
*   Did you use the property of "the order of elements can be changed"?
*   What happens when the elements to remove are rare?
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    public class Solution027 
    {
        public static int RemoveElement(int[] nums, int val) 
        {

            if(nums.Length == 0 || nums == null) return 0;
            var index = 0;
            for(var i = 0; i < nums.Length; i++)
            {
                if(nums[i] != val)
                {
                    nums[index] = nums[i];
                    index++;
                }
            }
            return index;
        }
    }
}

