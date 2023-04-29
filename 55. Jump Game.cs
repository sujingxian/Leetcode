public class Solution {
    public bool CanJump(int[] nums) {
        int n = nums.Length;
    int farthest = 0;
    for (int i = 0; i < n; i++) {
        if (i > farthest) { // if we can't reach this position, return false
            return false;
        }
        farthest = Math.Max(farthest, i + nums[i]); // update farthest position we can reach
    }
    return true;
    }
}
