public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char, int> map = new Dictionary<char, int>();
    foreach (char c in s) {
        if (map.ContainsKey(c)) {
            map[c]++;
        } else {
            map[c] = 1;
        }
    }
    for (int i = 0; i < s.Length; i++) {
        if (map[s[i]] == 1) {
            return i;
        }
    }
    return -1;
    }
}
