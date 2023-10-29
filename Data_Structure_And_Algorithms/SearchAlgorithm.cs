using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_And_Algorithms
{
    public static class SearchAlgorithm
    {
        public static int interpolationSearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            while(left <= right && target >= arr[left] && target <= arr[right])
            {
                int pos = left + ((target - arr[left]) * (right - left)) / (arr[right] - arr[left]);
                if (arr[pos] == target)
                {
                    return pos;
                }
                else if (arr[pos] < target)
                {
                    left = pos +1;
                }
                else
                {
                    right = pos -1;
                }
            }
            return -1;
        }
  
    public static int JumpSearch(int[] arr, int target)
    {
        int n = arr.Length;
        int step = (int)Math.Sqrt(n);
        int prev = 0;
        while (arr[Math.Min(step,n)] < target)
        {
            prev = step;
            step += (int)Math.Sqrt(n);
            if(prev >= n)
            {
                return -1;
            }

        }
        while (arr[prev] < target)
        {
            prev++;
            if(prev == Math.Min(step, n))
            {
                return -1;
            }
        }
        if (arr[prev] == target)
        {
            return prev;
        }
        return -1;
    }
    public static bool IsPalindrome(string palindrome)
        {
            palindrome = palindrome.ToLower();
            int start = 0;
            int end = palindrome.Length-1;
            while (start < end)
            {
                if (palindrome[start] != palindrome[end]) return false;
                start++;
                end--;
            }
            return true;
        }
}
}