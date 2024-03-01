public class Solution {
    public int MaxCoins(int[] piles) {
        int n = piles.Length;
        Array.Sort(piles);
        int count = 0;
        int len = n/3;
        int ind = n-2;
      // Getting the second element from the last will give you the second-largest maximum
        while(len-->0){
            count += piles[ind];
            ind = ind-2;
        }

        return count;
    }
}
