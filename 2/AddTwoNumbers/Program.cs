namespace AddTwoNumbers
{
    public class Program
    {
      public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var dummy = new ListNode(-1);
            var current = dummy;
            var carry = 0;

            while (l1 != null || l2 != null)
            {
                var value1 = l1 == null ? 0 : l1.val;
                var value2 = l2 == null ? 0 : l2.val;
                var sum = value1 + value2 + carry;
                carry = sum / 10;
                sum %= 10;
                current.next = new ListNode(sum);
                current = current.next;
                l1 = l1 == null ? null : l1.next;
                l2 = l2 == null ? null : l2.next;
            }

            if (carry != 0) {
                current.next = new ListNode(carry);
            }

            return dummy.next;
        }

      public static void Main(){}

      public static bool AreEqual(ListNode node1, ListNode node2)
        {
            while(node1 != null && node2 != null)
            {
                if(node1.val != node2.val)
                {
                    return false;
                }

                node1 = node1.next;
                node2 = node2.next;
            }

            return node1 == node2;
        }
    }

    public class ListNode 
    {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) 
      {
        this.val = val;
        this.next = next;
      }
    }
}
