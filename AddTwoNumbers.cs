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
 * Runtime : 124 ms
 * Problem:
 * You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
 * You may assume the two numbers do not contain any leading zero, except the number 0 itself.
 *
 * Solution: (Really not happy with cleaness of it)
 * The core of this is made up of a while loop on the current nodes' next value (along with a carry value).
 */
public class Solution {
    
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        // initialise orig node and carry
        (ListNode orig, int carry) = AddNodes(l1, l2, 0);
        ListNode prev = orig;
        
        // get next nodes
        l1 = l1.next;
        l2 = l2.next;
        
        // l1 and l2 may be different lengths
        while(l1 != null || l2 != null) {
            ListNode c = null;
            (c, carry) = AddNodes(l1, l2, carry);
            prev.next = c;
            prev = c;
            l1 = NextNodeOrNull(l1);
            l2 = NextNodeOrNull(l2);
        }
        
        // check for remaining carry
        if (carry != 0)
            prev.next = new ListNode(carry);

        return orig;
    }
    
    private (ListNode, int) AddNodes(ListNode first, ListNode second, int carry) {
        int fVal = first != null ? first.val : 0;
        int sVal = second != null ? second.val : 0;
        int val = fVal + sVal + carry;
        return (new ListNode(val % 10), val / 10);
    }
    
    private ListNode NextNodeOrNull(ListNode n) {
        if (n == null || n.next == null)
            return null;
        return n.next;
    }
}
