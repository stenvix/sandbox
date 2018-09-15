namespace Medium._2._Add_Two_Numbers
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }
    }

    public class AddTwoNumbersSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var currentSum = l1.val + l2.val;
            var remainder = (currentSum / 10);
            var head = new ListNode(currentSum % 10);
            var current = head;

            var firstNext = l1.next;
            var secondNext = l2.next;
            
            while (firstNext != null || secondNext != null)
            {
                if (firstNext == null || secondNext == null)
                {
                    currentSum = (secondNext?.val ?? firstNext.val) + remainder;
                    remainder = (currentSum / 10);
                    var next = new ListNode(currentSum % 10);
                    current.next = next;
                    current = next;
                    firstNext = firstNext?.next;
                    secondNext = secondNext?.next;
                    continue;
                }

                currentSum = firstNext.val + secondNext.val + remainder;
                remainder = (currentSum / 10);
                var newItem = new ListNode(currentSum % 10);
                current.next = newItem;
                current = newItem;
                firstNext = firstNext.next;
                secondNext = secondNext.next;
            }

            if (remainder != 0)
            {
                current.next = new ListNode(remainder);
            }

            return head;
        }
    }
}