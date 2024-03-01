public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);

        int gind = g.Length-1;
        int sind = s.Length-1;
        int count = 0;

        while(gind >=0 && sind >=0){
            if(g[gind]<=s[sind]){
                sind--;
                count++;
            }
            gind--;
        }

        return count;
    }
}
