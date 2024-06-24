namespace main;

public class LinkedLists
{
    ListNode? head = null;
    private class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public void add(int val)
    {
        var node = new ListNode(val);

        if (head == null)
        {
            head = node;
        }
        else
        {
            var current = head;
            if (current != null)
            {
                while (current != null)
                {
                    if (current.next == null)
                    {
                        current.next = new ListNode(val);
                        break;
                    }
                    current = current.next;
                }
            }
        }
    }

    public void del(int val)
    {
        var current = head;
        if (current != null)
        {
            while (current != null)
            {
                if (current.next?.val == val)
                {
                    current.next = current.next.next;
                    break;
                }
                current = current.next;
            }
        }
    }

    public void print()
    {
        var current = head;
        if (current != null)
        {
            while (current != null)
            {
                Console.Write($"[{current.val}]->");
                current = current.next;
            }
            Console.WriteLine($"NULL");
        }
    }

    public void RemoveNthFromEnd(int n)
    {
        var current = head;
        int length = 0;

        if (current != null)
        {
            while (current != null)
            {
                current = current.next;
                length++;
            }

            current = head;
            int travel = length - n - 1;
            length = 0;

            while (current != null)
            {
                if (travel == length)
                {
                    current.next = current.next?.next;
                    break;
                }
                length++;
                current = current.next;
            }
        }
    }

    public void reverse()
    {
        ListNode? prev = null;
        ListNode? current = head;

        if (current != null)
        {
            while (current != null)
            {
                ListNode next = current.next; 
                current.next = prev;
                prev = current;
                current = next;
                
            }
            head = prev;
        }
    }

    //public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    //{
    //    // Create a dummy node to act as the starting point of the merged list
    //    ListNode dummy = new ListNode();
    //    ListNode current = dummy;
    //    // Traverse both lists and splice together the nodes in sorted order
    //    while (list1 != null && list2 != null)
    //    {
    //        if (list1.val <= list2.val)
    //        {
    //            current.next = list1;
    //            list1 = list1.next;
    //        }
    //        else
    //        {
    //            current.next = list2;
    //            list2 = list2.next;
    //        }
    //        current = current.next;
    //    }
    //    // If any nodes remain in either list, append them to the merged list
    //    if (list1 != null)
    //    {
    //        current.next = list1;
    //    }
    //    else if (list2 != null)
    //    {
    //        current.next = list2;
    //    }
    //    // Return the merged list, which starts at dummy.next
    //    return dummy.next;
    //}
}
