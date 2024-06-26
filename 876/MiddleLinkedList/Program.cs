namespace MiddleLinkedList
{
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
    public class Program
    {
      public static ListNode MiddleNode(ListNode head) 
        {
            List<ListNode> vector = new List<ListNode>();
            int length = 0;
        
            while (head != null)
            {
                vector.Add(head);
                head = head.next;
                length++;
            }
            return vector[length/2];
        }

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



      public static void Main(){}
    }
}
