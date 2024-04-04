public class Solution {
    public int MaxDepth(string s) {
        int max = 0;
        int curr = 0;
        foreach(var l in s){
            if(l=='('){
                curr++;
                max = Math.Max(curr, max);
            }else if(l==')'){
                curr--;
            }
        }

        return max;
    }
}
