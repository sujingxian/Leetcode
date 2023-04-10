public class Solution {
    public int MyAtoi(string s) {
        if (string.IsNullOrEmpty(s)) {
            return 0;
        }
        //is emtry
        s = s.Trim();
        if (string.IsNullOrEmpty(s)) {
            return 0;
        }
        //ignore white space
        StringBuilder result = new StringBuilder(); 
        bool isPositive = true;
        for (int i = 0; i < s.Length; i++) {
            if (Char.IsDigit(s[i])) {
                result.Append(s[i]);
            } else if (i == 0 && (s[i] == '-' || s[i] == '+')) {
                isPositive = s[i] == '+';
                //whether have "-" or "+"
            } else {
                break;
            }
        }
        
        BigInteger num;
        if (BigInteger.TryParse(result.ToString(), out num) ) 
        {
            
            if (isPositive == false)
            {
                num = 0 - num;
                if ((BigInteger)num < int.MinValue)
                {
                    return int.MinValue;
                }
                else
                {
                    return (int)num;
                }
            }
            else
            {
                if ((BigInteger)num > int.MaxValue)
                {
                    return int.MaxValue;
                }
                return (int)num;
            }

        } 
        else 
        {
            return 0;
        }
    }
}
