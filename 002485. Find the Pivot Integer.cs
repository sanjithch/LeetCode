public class Solution {
    public int PivotInteger(int n) {
        double x = Math.Sqrt(n*(n+1)/2);
        int ro = (int)x;
        double dif = x - (double)ro;
        
        return dif > 0 ? -1 : ro;
    }
}
