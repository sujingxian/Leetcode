public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1) 
        {
            return s;
        }
    
        StringBuilder[] rows = new StringBuilder[numRows];
        //create the array with numRows size
        for (int i = 0; i < numRows; i++) 
        {
            rows[i] = new StringBuilder();
        }
        //every element in array is a string builder
        int row = 0;
        int step = 1;
        foreach(char c in s)
        {
            rows[row].Append(c);
            if(row == 0)
            {
                step = 1;
            }
            else if(row == numRows -1)
            {
                step = -1;
            }
            row += step;
        //no.1 row is the first step
        //step will add 1 each time
        //if row going to the last line step equal to -1 and row will be minus 1
        }
        StringBuilder result = new StringBuilder();
        foreach (StringBuilder rowStr in rows) 
            {
                result.Append(rowStr);
            }
        //create a stringbuilder
        //foreach all element in the array and add to new string builder
        return result.ToString();
        //convert to string
        
    }
}
