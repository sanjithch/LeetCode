public class Solution {
    public bool WinnerOfGame(string colors) {
        int n = colors.Length;
        int a = 0;
        int b = 0;
        int aCount = 0;
        int bCount = 0;

        for(int i=0;i<n;i++){
            if(colors[i]=='A'){
                bCount = 0;
                if(aCount==2){
                    a++;
                }
                else{
                    aCount++;
                }
            }
            else{
                aCount = 0;
                if(bCount == 2){
                    b++;
                }
                else{
                    bCount++;
                }
            }
        }

        return a>b;
    }
}
