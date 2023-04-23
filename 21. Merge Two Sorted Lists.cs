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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
       // create a dummy head for the merged list
        ListNode dummy = new ListNode(0);
        // create a pointer to the tail of the merged list
        ListNode tail = dummy;
        
        // iterate over both lists simultaneously
        while (list1 != null && list2 != null) {
            // compare the values of the current nodes in both lists
            if (list1.val <= list2.val) {
                tail.next = list1;
                list1 = list1.next;
            } else {
                tail.next = list2;
                list2 = list2.next;
            }
            tail = tail.next;
        }
        
        // append the remaining nodes of either list to the merged list
        if (list1 != null) {
            tail.next = list1;
        } else {
            tail.next = list2;
        }
        
        // return the head of the merged list (skip the dummy head)
        return dummy.next;
    }
}
