using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SortedDictionary<int, int> nums = new SortedDictionary<int, int>();

            foreach (var number in input) 
            {
                if (nums.ContainsKey(number))
                {
                    nums[number]++;
                }
                else
                {
                    nums.Add(number, 1);
                }
            }
            foreach (var number in nums) 
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
