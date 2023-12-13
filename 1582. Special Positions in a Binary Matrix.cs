public class Solution {
    public int NumSpecial(int[][] mat) {
        int n = mat.Length;
        int m = mat[0].Length;
        int[] rows = new int[n];
        int[] cols = new int[m];

        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                if(mat[i][j]==1){
                    rows[i]++;
                    cols[j]++;
                }
            }
        }
        int count = 0;
        for(int i=0;i<n;i++){
            if(rows[i]==1){
                for(int j=0;j<m;j++){
                    if(mat[i][j]==1 && cols[j]==1) count++;
                }
            }
        }

        return count;
    }
}
