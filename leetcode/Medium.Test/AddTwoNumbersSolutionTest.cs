using System;
using System.Collections.Generic;
using Medium._2._Add_Two_Numbers;
using Xunit;

namespace Medium.Test
{
    public class AddTwoNumbersSolutionTest
    {
        [Fact]
        public void AddTwo()
        {
            var random = new Random();
            var firstNumbers = new List<int>();
            var secondNumbers = new List<int>();

            ListNode firstHead = null;
            ListNode secondHead = null;
            ListNode firstNext = null;
            ListNode secondNext = null;
            for (int i = 0; i < 3; i++)
            {
                var firstNumber = random.Next(0, 10);
                var secondNumber = random.Next(0, 10);

                var one = new ListNode(firstNumber);
                var two = new ListNode(secondNumber);
                if (i == 0)
                {
                    firstHead = one;
                    secondHead = two;
                    firstNext = firstHead;
                    secondNext = secondHead;
                }

                firstNext.next = one;
                secondNext.next = two;

                firstNext = one;
                secondNext = two;
            }

            firstHead = new ListNode(1);
            secondHead = new ListNode(9)
            {
                next = new ListNode(9)
            };
            var solution = new AddTwoNumbersSolution();
            solution.AddTwoNumbers(firstHead, secondHead);
        }
    }
}