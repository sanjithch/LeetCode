public class Solution {
    public int[][] ImageSmoother(int[][] img) {
        int n = img.Length;
        int m = img[0].Length;
        int[][] result = new int[n][];
        for(int i=0;i<n;i++) result[i] = new int[m];
        int sum = 0;
        int count = 0;

        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                sum = img[i][j];
                count = 1;
                //left 
                if(i>0){
                    sum += img[i-1][j];
                    count++;
                    if(j>0){
                        sum += img[i-1][j-1];
                        count++;
                    }
                    if(j<m-1){
                        sum += img[i-1][j+1];
                        count++;
                    }
                }
                //right
                if(i<n-1){
                    sum += img[i+1][j];
                    count++;
                     if(j>0){
                        sum += img[i+1][j-1];
                        count++;
                    }
                    if(j<m-1){
                        sum += img[i+1][j+1];
                        count++;
                    }
                }
                //top
                if(j>0){
                    sum += img[i][j-1];
                    count++;
                }
                //bottom
                if(j<m-1){
                    sum += img[i][j+1];
                    count++;
                }
                if(count>0){
                    // Console.WriteLine(i+ " "+ j + " " + sum+ " " +count);
                    result[i][j] = sum/count;
                }
            }
        }

        return result;
    }
}
