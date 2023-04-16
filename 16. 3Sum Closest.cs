public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        int closestSum = 0;
        Array.Sort(nums);
        int dis = int.MaxValue;
        for(int i = 0;  i < nums.Length -2; i ++)
        {
            int j = i + 1; 
            int k = nums.Length -1;
            while(j < k)
            {
                int sum = nums[i] + nums[j] + nums[k];
                if (Math.Abs(target - sum) < dis)
                {
                    dis = Math.Abs(target - sum);
                    closestSum = sum;
                }
                if (sum == target)
                {
                    return sum;
                }
                if (sum < target)
                {
                    j++;
                }
                if (sum > target)
                {
                    k--;
                }

            }
        }
        return closestSum;
        
    }
}
