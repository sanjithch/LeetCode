public class Solution {
    public int MaxWidthOfVerticalArea(int[][] points) {
        Array.Sort(points, (a,b)=> a[0]-b[0]);
        int max = 0;
        for(int i=0;i<points.Length-1;i++){
            max = Math.Max(points[i+1][0]-points[i][0], max);
        }

        return max;
    }
}
