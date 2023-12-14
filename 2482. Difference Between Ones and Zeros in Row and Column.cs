public class Solution {
    public int[][] OnesMinusZeros(int[][] grid) {
        int n = grid.Length;
        int m = grid[0].Length;
        int[,] rows = new int[2,n];
        int[,] cols = new int[2,m];

        int[][] result = new int[n][];
        for(int i=0;i<n;i++) result[i] = new int[m];

        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                if(grid[i][j]==1){
                    rows[1,i]++;
                    cols[1,j]++;
                }
                else{
                    rows[0,i]++;
                    cols[0,j]++;
                }
            }
        }

        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                result[i][j] = rows[1,i] - rows[0,i] + cols[1,j] - cols[0,j];
            }
        }

        return result;
    }
}
