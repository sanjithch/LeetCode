public class Solution {
    public bool BackspaceCompare(string s, string t) {
        string sFinal = helper(s);
        string tFinal = helper(t);

        if(sFinal==tFinal) return true;
        return false;
    }

    // loop from the back, then we can remove what not be needed
    public string helper(string s){
        int sLen = s.Length;
        StringBuilder sFinal = new StringBuilder();
        int removingCount = 0;
        for(int i=sLen-1;i>=0;i--){
            if(s[i]=='#'){
                removingCount++;
            }
            else {
                if(removingCount>0){
                    removingCount--;
                }
                else if(removingCount==0){
                    sFinal.Insert(0, s[i]);
                }
            }
        }

        return sFinal.ToString();
    }
}
