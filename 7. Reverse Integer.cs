public class Solution {
    public int Reverse(int x) {
        if ((long)x < int.MinValue || (long)x > int.MaxValue)
        {
            return 0;
        }
        
        int answer = 0;
        StringBuilder reverse = new StringBuilder();
        
        if(x >= 0)
        {
            String result = x.ToString();
            for ( int i = result.Length -1; i >= 0; i --)
            {
                reverse.Append(result[i]);
            }
            int.TryParse(reverse.ToString(), out answer);
        }
        else if(x < 0)
        {
            x = 0 - x;
            String result = x.ToString();
            for ( int i = result.Length -1; i >= 0; i --)
            {
                reverse.Append(result[i]);
            }
            int.TryParse(reverse.ToString(), out answer);
            answer = 0 - answer;
        }
        return answer;
    }
}
