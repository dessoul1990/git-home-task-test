using System;
using System.Collections.Generic;
using System.Text;

namespace Homework2
{
    class LinkedLink
    {
        int count;
        LinkedLinkNode head;

        public LinkedLink()
        {
            head = null;
            count = 0;
        }
        public void AddNodeToFront(int data)
        {
            LinkedLinkNode node = new LinkedLinkNode(data);
            node.next = head;
            head = node;
            count++;
        }
        public void PrintList()
        {
            LinkedLinkNode runner = head;
            while(runner != null)
            {
                Console.WriteLine(runner.data);
                runner = runner.next;
            }
        }    
        public void RemoveNode(int data)
        {           
            if (head != null)
            {
                if (head.data.Equals(data))
                {
                    head = head.next;
                    count--;
                    return;
                }
                var current = head.next;
                var previous = head;
                while(current != null)
                {
                    if (current.data.Equals(data))
                    {
                        previous.next = current.next;
                        count--;
                    }
                }
            }
        }
    }
}
