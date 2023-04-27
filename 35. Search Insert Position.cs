public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int left = 0;
        int right = nums.Length -1;
        while (left <= right)
        {
            int mid = (left + right)/2;
            if (target == nums[mid])
            {
                return mid;
            }
            else if (target > nums[mid])
            {
                left = mid +1;
            }
            else
            {
                right = mid -1;
            }
        }
        return left;
    }
}
