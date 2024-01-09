int[] nums = { 0, 2, 1, 5, 3, 4 };
//int[] nums = { 5, 0, 1, 2, 3, 4 };
int[] ans = new int[nums.Length];

var result = BuildArray(nums);
var d = result;

int[] BuildArray(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        ans[i] = nums[nums[i]];
    }
    return ans;
}
//ans[0]=nums[0]=0  ans[0]
//ans[1]=nums[1]=2  ans[0,1]
//ans[2]=nums[2]=1  ans[0,1,2]
//ans[3]=nums[3]=5  ans[0,1,2,4]
//ans[4]=nums[4]=3  ans[0,1,2,4,5]
//ans[5]=nums[5]=4  ans[0,1,2,4,5,3]

