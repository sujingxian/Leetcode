public class Solution {
    public int[][] MatrixReshape(int[][] mat, int r, int c) {
        int rows = mat.Length;
        int cols = mat[0].Length;
        if (rows * cols != r * c) {
            // 原始矩阵和目标矩阵的元素个数不一样，无法重塑
            return mat;
        }
        int[][] result = new int [r][];
        for ( int i = 0; i < r; i ++)
        {
            result[i] = new int[c];

        } 
        int row = 0, col = 0;
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                result[row][col] = mat[i][j];
                col++;
                if (col == c) {
                    row++;
                    col = 0;
                }
            }
        }
        return result;
        
    }
}
