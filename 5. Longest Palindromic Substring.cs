public class Solution {
    public string LongestPalindrome(string s) {
        int n = s.Length;
    bool[,] dp = new bool[n, n];
    int maxLength = 0;
    int start = 0;
    
    // All substrings of length 1 are palindromes
    for (int i = 0; i < n; i++) {
        dp[i, i] = true;
        maxLength = 1;
    }
    
    // Check substrings of length 2
    for (int i = 0; i < n - 1; i++) {
        if (s[i] == s[i+1]) {
            dp[i, i+1] = true;
            maxLength = 2;
            start = i;
        }
    }
    
    // Check substrings of length > 2
    for (int len = 3; len <= n; len++) {
        for (int i = 0; i < n - len + 1; i++) {
            int j = i + len - 1;
            if (s[i] == s[j] && dp[i+1, j-1]) {
                dp[i, j] = true;
                if (len > maxLength) {
                    maxLength = len;
                    start = i;
                }
            }
        }
    }
    
    return s.Substring(start, maxLength);
    }
}
