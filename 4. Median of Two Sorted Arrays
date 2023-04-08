public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] combined = nums1.Concat(nums2).ToArray();
        Array.Sort(combined);
        int midIndex = combined.Length / 2;
        if(combined.Length % 2 == 0)
        {
            return Convert.ToDouble((combined[midIndex - 1] + combined[midIndex])) / 2;
        }
        return combined[midIndex];
        
    }
}
