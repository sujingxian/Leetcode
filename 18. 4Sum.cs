public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums); // Sort the input array to make it easier to find the unique quadruplets
        int n = nums.Length;
        
        // Check if all numbers in the array are the same and the target is negative
        if (target < 0 && nums[0] == nums[n-1])
        {
            return result;
        }
        
        for (int a = 0; a < n - 3; a++) 
        { // Outer loop for the first number
            if (a > 0 && nums[a] == nums[a - 1])
            { 
                continue; // Skip duplicate values
            }
            for (int b = a + 1; b < n - 2; b++) 
            { // Inner loop for the second number
                if (b > a + 1 && nums[b] == nums[b - 1]) 
                {
                    continue;
                } // Skip duplicate values
                int c = b + 1, d = n - 1; // Set pointers for the third and fourth numbers
                while (c < d) 
                {
                    int sum = nums[a] + nums[b] + nums[c] + nums[d];
                    if (sum == target) 
                    {
                        result.Add(new List<int> {nums[a], nums[b], nums[c], nums[d]});
                        c++; d--; // Move pointers to find new pairs
                        while (c < d && nums[c] == nums[c - 1]) c++; // Skip duplicate values
                        while (c < d && nums[d] == nums[d + 1]) d--; // Skip duplicate values
                    }
                    else if (sum < target) c++; // Sum is too small, move c pointer right
                    else d--; // Sum is too large, move d pointer left
                }
            }
        }
        return result;
    }
}
