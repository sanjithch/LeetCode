/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */

// tortoise and rabbit approach
public class Solution {
    public bool HasCycle(ListNode head) {
        if(head==null) return false;

        ListNode tort = head;
        ListNode rab = head;

        // first step
        if(head.next!=null){
            tort = tort.next;
            rab = rab.next;
        }else{
            return false;
        }

        if(rab.next!=null){
            rab = rab.next;
        }else{
            return false;
        }

        while(tort!=rab){
            if(tort==null || rab==null) return false;
            if(tort.next!=null) tort = tort.next;
            else return false;
            if(rab.next!=null){
                rab = rab.next;
                if(rab.next!=null){
                    rab = rab.next;
                }else{
                    return false;
                }
            }else{
                return false;
            }
        }


        return true;

    }
}
