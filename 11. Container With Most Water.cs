public class Solution {
    public int MaxArea(int[] height) {
     int i = 0;
     int j = height.Length -1;
     int space = 0;
     int result = 0;
     while (i != j)
     {
         if (height[i] <= height[j])
         {
             space = height[i] * (j-i);
             i++;
         }
         else 
         {
             space = height[j] * (j-i);
             j--;
         }
         if (space > result)
         {
             result = space;
         }
     }
     return result;
    }
}
