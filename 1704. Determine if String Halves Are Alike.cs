public class Solution {
    public bool HalvesAreAlike(string s) {
        int n = s.Length;
        int count = 0;
        for(int i=0;i<n/2;i++){
            if(isVowel(s[i])){
                count++;
            }
        }
        for(int i=n/2;i<n;i++){
            if(isVowel(s[i])){
                count--;
            }
        }
        if(count==0) return true;
        return false;
    }

    public bool isVowel(char c){
        if(c=='a' || c=='A'){
            return true;
        }
        if(c=='e' || c=='E'){
            return true;
        }
        if(c=='i' || c=='I'){
            return true;
        }
        if(c=='o' || c=='O'){
            return true;
        }
        if(c=='u' || c=='U'){
            return true;
        }

        return false;
    }
}
