public class Solution {
    public void Rotate(int[] nums, int k) {
        if (k == 0)
        {
            return;
        }
        
        Array.Reverse(nums);
        Array.Reverse(nums, 0, k % nums.Length);
        Array.Reverse(nums, k % nums.Length, nums.Length - k % nums.Length);
        
        
    }
}
