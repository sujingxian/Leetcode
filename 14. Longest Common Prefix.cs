public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string result = "";
        bool equal = true;
        int shortest = strs[0].Length;
        for (int n = 0; n < strs.Length; n++) {
            if (strs[n].Length < shortest) {
                shortest = strs[n].Length;
            }
        }

        if (strs.Length == 1)
        {
            return strs[0];
        }


        
        if ( shortest == 0){
            return result;
        }
        
        else 
        {
            int i = 0;
            while(i < shortest)
            {
                for ( int j = 0; j < strs.Length -1; j ++)
                {
                    if(strs[j][i] != strs[j+1][i])
                    {
                        equal = false;
                        break;
                    }
                    
                }
                if(equal == true)
                {
                    result +=strs[0][i];
                    i ++;
                }
                else if (equal == false)
                {
                    return result; 
                }
            }

        }
        return result;
        
        
        
            
        
      

    }
}
