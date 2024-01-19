public class Solution {
    int[,] arr;
    public int MinFallingPathSum(int[][] matrix) {
        int n = matrix.Length;
        int min = 1000000;
        arr = new int[n,n];
        for(int i=0;i<n;i++) for(int j=0;j<n;j++) arr[i,j] = 10000000;
        for(int i=0;i<n;i++){
            min = Math.Min(min, helper(0, i, n, matrix, true, true));
        }
        return min;
    }

    public int helper(int x, int y, int n, int[][] matrix, bool left, bool right){
        if((y < 0 || y > n-1) && x < n) return 100000;

        if(x == n-1){
            int a = matrix[x][y];
            if(y > 0 && left) a = Math.Min(a, matrix[x][y-1]);
            if(y < n-1 && right) a = Math.Min(a, matrix[x][y+1]);
            return a;
        }

        if(arr[x,y]!=10000000) return arr[x, y];

        int min =  Math.Min(helper(x+1, y-1, n, matrix, false, true), helper(x+1, y, n, matrix, true, true));
        min = Math.Min(min, helper(x+1, y+1, n, matrix, true, false));
        min += matrix[x][y];
        arr[x,y] = min;
        return min;
    }
}
