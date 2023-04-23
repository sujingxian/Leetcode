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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
      // Create a dummy node and set it as the new head
    ListNode dummy = new ListNode(0);
    dummy.next = head;

    // Move the first pointer n nodes to make sure that two pointers got a distance as n
    ListNode first = dummy;
    for (int i = 0; i < n; i++) 
    {
        first = first.next;
    }

    // Move both pointers until the first pointer reaches the end of the list
    ListNode second = dummy;
    while (first.next != null) 
    {
        first = first.next;
        second = second.next;
    }

    // Remove the nth node by updating the next pointer of the previous node
    second.next = second.next.next;

    // Return the head of the modified list
    return dummy.next;
        
    }
}
