public class Solution {
    public int MaximumElementAfterDecrementingAndRearranging(int[] arr) {
        int n = arr.Length;
        Array.Sort(arr);
        int curr = 2;
        arr[0] = 1;
      //Assign the first element to 1
      //It is best to arrange the elements in ascending order, and then perform the required operations
      //take the current as the max you can assign
        for(int i=1;i<n;i++){
            if(arr[i]==curr-1){
                continue;
            }
            if(arr[i]==curr){
               curr++;
            }
            else{
                arr[i] = curr++;
            }
        }
        return arr[n-1];
    }
}
