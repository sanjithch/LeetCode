public class Solution {
    public int CountTestedDevices(int[] batteryPercentages) {
        int dec = 0;
        int count = 0;
        int n = batteryPercentages.Length;
        
        for(int i=0;i<n;i++){
            if(batteryPercentages[i]-dec > 0){
                dec++;
                count++;
            }
        }
        
        return count;
    }
}
