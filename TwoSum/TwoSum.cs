public class Solution
{
    public int[] TwoSum(int[] nums, int target) 
    {
        int[] result = new int[] {0};
        for (int i=0; i < nums.Length; i++)
        {
            for (int j=i+1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    result = [i,j];
                }
            }
        }
        return result;
    }
}
