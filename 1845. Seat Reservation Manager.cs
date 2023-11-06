public class SeatManager {
    int i=1;
    List<int> unreserved = new List<int>(){0};
    public SeatManager(int n) {
        unreserved.Add(n+1);
    }
    
    int val = 0;
    public int Reserve() {
        if(unreserved.Count>2){
            val = unreserved[1];
            unreserved.RemoveAt(1);
            return val;
        }
        return i++;
    }
    
    public void Unreserve(int seatNumber) {
        fetchIndex(seatNumber);
    }

    public void fetchIndex(int se){
        if(unreserved.Count==2) {
            unreserved.Insert(1, se);
            return;
        }
        int left = 0;
        int right = unreserved.Count-1;
        int mid = (left+right)/2;
      // 
        while(left<right){
            mid = (left+right)/2;
            if(unreserved[mid] < se && unreserved[mid+1] > se){
                mid++;
               break;
            }
            if(unreserved[mid] < se){
                left = mid+1;
            }
            else{
                right = mid-1;
            }
        }
        mid = Math.Max(left, right);
        left = Math.Min(left, right);
        right = mid;
        mid = left+1;
        while(mid<right){
            if(unreserved[mid-1] < se && unreserved[mid] > se){
                 break;
            }
            mid++;
        }
        unreserved.Insert(mid, se);
        
    }
}

/**
 * Your SeatManager object will be instantiated and called as such:
 * SeatManager obj = new SeatManager(n);
 * int param_1 = obj.Reserve();
 * obj.Unreserve(seatNumber);
 */
