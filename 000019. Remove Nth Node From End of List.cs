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
    int level = 0;
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        helper(head, n);
        if(level==1) return null;

        return head;
    }

    public int helper(ListNode head, int n){
        if(head==null) return 0;
        int val = helper(head.next, n);
        level++;
        int val2 = head.val;
        if(level<=n){
            head.val = val;
        }
        if(level==2) head.next = null;
        return val2;
    }
}
