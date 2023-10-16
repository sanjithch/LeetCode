public class Solution {
    public IList<int> GetRow(int rowIndex) {
        int[] arr = new int[rowIndex+1];

      // filled the array with one
        Array.Fill(arr, 1);

       // a binomial equation follows as this - nc0, nc1, nc2,..., ncn
      // we know that nci = nc(n-i)
        for(int i=1;i<=rowIndex/2;i++){
            arr[i] = (int)((long)((long)arr[i-1]*(long)(rowIndex-i+1))/(long)(i));
            arr[rowIndex-i] = arr[i];
        }

        return arr;
    }
}
