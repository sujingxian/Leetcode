public class Solution {
    public string IntToRoman(int num) {
        
        string[] symbols = {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};
        int[] values = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};

        StringBuilder s = new StringBuilder();

        for (int i = 0; i < symbols.Length; i++)
        {
            while (num >= values[i])
            {
                num -= values[i];
                s.Append(symbols[i]);
            }
        }

        return s.ToString();
    }
}
