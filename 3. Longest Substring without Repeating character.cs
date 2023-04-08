public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> set = new HashSet<char>();
        int n = s.Length;
        int i = 0;
        int j = 0;
        int current = 0;
        int count = 0;
        while(i < n && j < n)
        {
            if (!set.Contains(s[j]))
            {
                set.Add(s[j]);
                j++;
                count = Math.Max(count, j - i);
            }
            else
            {
                set.Remove(s[i]);
                i++;
                

            }
        }
       return count;
    }
}
