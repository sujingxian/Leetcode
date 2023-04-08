public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        
        for ( int i = 0; i < matrix.Length; i++)
        {
            if (target > matrix[i][0] && target < matrix[i][matrix[i].Length-1])
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (target == matrix[i][j])
                    {
                        return true;
                    }
                }
            }
            else if(matrix[i][0] == target || matrix[i][matrix[i].Length-1] == target)
            {
                return true;
            }
        }
        return false;
    }
}
