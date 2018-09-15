namespace Easy._1._Two_Sum
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var currentNumber = nums[i];

                var nextNumber = target - currentNumber;

                var nextIndex = IndexOf(nums, nextNumber, i);
                if (nextIndex >= 0)
                {
                    return new[] {i, nextIndex};
                }
            }

            return new int[2];
        }

        private int IndexOf(int[] nums, int target, int skipIndex)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == skipIndex)
                {
                    continue;
                }

                if (nums[i] == target)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}