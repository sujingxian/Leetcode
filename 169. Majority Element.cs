public class Solution {
    public int MajorityElement(int[] nums) {
        Array.Sort(nums);
        int n = nums.Length;
        int index = n/2;
        return nums[index];
    }
}
