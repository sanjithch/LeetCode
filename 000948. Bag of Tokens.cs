public class Solution {
    public int BagOfTokensScore(int[] tokens, int power) {
        Array.Sort(tokens);
        int n = tokens.Length;

        int maxScore = 0;
        int score = 0;

        int left = 0;
        int right = n-1;

        while(left<=right){

            // face up
            if(power>=tokens[left]){
                score++;
                maxScore = Math.Max(score, maxScore);
                power -= tokens[left++];
            }else if(power < tokens[left] && score==0){
                break;
            }else if(score>0){
                power += tokens[right--];
                score--;
            }

        }

        return maxScore;
    }
}
