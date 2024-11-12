namespace Problems.Medium
{
    public class ListNode(int val = 0, ListNode? next = null)
    {
        public int val = val;
        public ListNode? next = next;
    }
    public class Leet2
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            //Instantiate a result LinkedList
            ListNode result = new();
            ListNode head = result;

            int sum = 0;
            //Keep running while one of these conditions are met
            while (l1 != null || l2 != null || sum > 0)
            {
                //Case where L1 or L2 is larger than the other
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next!;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next!;
                }
                //Add the digit to the result node
                result.next = new ListNode(sum % 10);

                //Store the carry either 1 or 0
                sum /= 10;

                result = result.next;
            }
            //Skip the dummy head node
            return head.next!;
        }
    }
}
