public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // use hashset
        //Hashset is a collection that cannot contain the same value
        
        //for row
        for (int i = 0; i < 9; i ++)
        {
            HashSet<char> set = new HashSet<char>();
            for ( int j = 0; j < 9; j++)
            {
                if (board[i][j] != '.' && !set.Add(board[i][j]))
                {
                    return false;
                }
            }
        }
        //for column
        for (int j = 0; j < 9; j ++)
        {
            HashSet<char> set = new HashSet<char>();
            for ( int i = 0; i < 9; i++)
            {
                if (board[i][j] != '.' && !set.Add(board[i][j]))
                {
                    return false;
                }
            }
        }
        // for 3*3
        for (int box = 0; box < 9; box++) 
        {
            HashSet<char> set = new HashSet<char>();
            for (int i = box / 3 * 3; i < box / 3 * 3 + 3; i++) 
            {
                for (int j = box % 3 * 3; j < box % 3 * 3 + 3; j++) 
                {
                
                    if (board[i][j] != '.' && !set.Add(board[i][j])) 
                    {
                        return false;
                    }
                }
            }
        }
        return true;
    }
}
