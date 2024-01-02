namespace Concatenation_of_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 2, 1 };
            int[] ans = new int[nums.Length * 2];

            var result = GetConcatenation(nums);
            int[] GetConcatenation(int[] nums)
            {
                int index = 0;
                for (int i = 0; i <= 1; i++)
                {
                    for (int j = 0; j < nums.Length; j++)
                    {
                        ans[index] = nums[j];
                        index++;
                    }
                }
                var d = ans;
                return ans;
            }


        }
    }
}
