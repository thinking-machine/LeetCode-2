// Source : https://leetcode.com/problems/permutation-sequence/ 
// Author : codeyu 
// Date : Saturday, December 10, 2016 10:33:39 PM 

/**********************************************************************************
*
* The set [1,2,3,&#8230;,n] contains a total of n! unique permutations.
* 
* By listing and labeling all of the permutations in order,
* We get the following sequence (ie, for n = 3):
* 
* "123"
* "132"
* "213"
* "231"
* "312"
* "321"
* 
* 
* 
* Given n and k, return the kth permutation sequence.
* 
* Note: Given n will be between 1 and 9 inclusive.
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    public class Solution060 
    {
        public static string GetPermutation(int n, int k) 
        {
            int total = factorial(n);
            string candidate = ("123456789").Substring(0, n);
            string res = "";
            for(int i = 0; i < n; i++)//依次计算排列的每个位
            {
                total /= (n-i);
                int index = (k-1) / total;
                res += candidate[index];
                candidate = candidate.Remove(index, 1);
                k -= index*total;
            }
            return res;
        }
        static int factorial(int n)
        {
            int res = 1;
            for(int i = 2; i <= n; i++)
                res *= i;
            return res;
        }
    }
}

