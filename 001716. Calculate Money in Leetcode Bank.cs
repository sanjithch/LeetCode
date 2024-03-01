public class Solution {
    public int TotalMoney(int n) {
        int balance = 0;
        int amount = 1;
        int day = 1;
        
        while(day<=n){
            balance += amount;
            amount++;
            if(day%7==0){
                amount = day/7+1;
            }
            day++;
        }

        return balance;
    }
}
