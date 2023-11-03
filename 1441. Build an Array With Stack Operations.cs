public class Solution {
    public IList<string> BuildArray(int[] target, int n) {
        List<string> arr = new List<string>();
        int len = target.Length;
        int iStream = 1;
        int dif = 0;
        for(int i=0;i<len;i++){
          //For every valid target add a push
            if(iStream==target[i]){
                arr.Add("Push");
            }
            else{
                dif = target[i]-iStream;
              //everything else add it and remove it
                while(dif>0){
                    dif--;
                    arr.Add("Push");
                    arr.Add("Pop");
                }
              // added the target element
                arr.Add("Push");
            }
          // the input stream is then reseted
            iStream = target[i]+1;
        }

        return arr;
    }
}
