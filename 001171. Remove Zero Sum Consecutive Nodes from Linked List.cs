/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RemoveZeroSumSublists(ListNode head) {
        List<int> arr = new List<int>();
        List<int> cum = new List<int>();
        ListNode temp = head;

        int pre = head.val;
        arr.Add(0);
        cum.Add(0);
        arr.Add(pre);
        cum.Add(pre);
        temp = temp.next;

        while(temp!=null){
            pre += temp.val;
            arr.Add(temp.val);
            cum.Add(pre);
            temp = temp.next;
        }

        int n = arr.Count;
        int i = 0, j = n-1;
        while(j>0){
            i=0;
            while(i<j){
                if(cum[j]-cum[i]==0){
                    arr.RemoveRange(i+1, j-i);
                    cum.RemoveRange(i+1, j-i);
                    n -= j-i;
                    j = n-1;
                    break;
                }
                i++;
            }
            j--;
        }
        if(arr.Count<=1) return null;
        ListNode result = new ListNode(arr[1]);
        ListNode temp1 = result;

        for(i=2;i<arr.Count;i++){
            temp1.next = new ListNode(arr[i]);
            temp1 = temp1.next;
        }

        
        return result;
        
    }
}
