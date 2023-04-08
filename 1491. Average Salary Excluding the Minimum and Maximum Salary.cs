public class Solution {
    public double Average(int[] salary) {
        double sum;
        double result;
        sum = salary.Sum() - salary.Max() - salary.Min();
        result = sum/ (salary.Length - 2);
        return result;

    }
}
