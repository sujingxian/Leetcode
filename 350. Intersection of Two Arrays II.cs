public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        List<int> result = new List<int>();
        
        Array.Sort(nums1);
        Array.Sort(nums2);
        int index1 = 0;
        int index2 = 0;
        while(index1 < nums1.Length && index2 < nums2.Length)
        {
            if(nums1[index1] == nums2[index2])
            {
                result.Add(nums1[index1]);
                index1++;
                index2++;
            }
            else if(nums1[index1] > nums2[index2])
            {
                index2 ++;
            }
            else
            {
                index1 ++;
            }
        }
        int[] results = result.ToArray();
        return results; 


        
    }
}
