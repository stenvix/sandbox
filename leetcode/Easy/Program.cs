using System;
using Easy._1._Two_Sum;

namespace Easy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var twoSum = new TwoSumSolution();
            twoSum.TwoSum(new[] {-1,-2,-3,-4,-5}, -8);
            Console.ReadLine();
        }
    }
}
