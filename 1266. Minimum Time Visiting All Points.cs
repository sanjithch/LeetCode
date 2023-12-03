public class Solution {
    public int MinTimeToVisitAllPoints(int[][] points) {
       int n = points.Length;
       int time = 0;
       for(int i=0;i<n-1;i++){
           time += distanceCalculator(Math.Abs(points[i][0] - points[i+1][0]), Math.Abs(points[i][1] - points[i+1][1]));
       }

       return time;
    }

    public int distanceCalculator(int xdif, int ydif){
       return Math.Min(xdif, ydif)+Math.Abs(xdif-ydif);
    }
}
