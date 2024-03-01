public class Solution {
    public int[] FindArray(int[] pref) {
        int n = pref.Length;
        int[] result = new int[n];
        result[0] = pref[0];
      // a^b = c then b^c = a
        for(int i=n-1;i>0;i--){
            result[i] = pref[i-1]^pref[i];
        }

        return result;
    }
}
