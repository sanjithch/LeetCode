public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        int n = grid.Length;
        bool[] hash = new bool[n*n];
        int[] result = new int[2];
        for(int i=0;i<n;i++){
            for(int j=0;j<n;j++){
                if(hash[grid[i][j]-1]){
                    result[0] = grid[i][j];
                }
                else{
                    hash[grid[i][j]-1] = true;
                }
            }
        }
        
        for(int i=0;i<n*n;i++){
            if(!hash[i]) result[1] = i+1;
        }
        
        return result;
    }
}
