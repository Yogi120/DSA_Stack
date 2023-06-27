using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Implementation
{
    public class Stack
    {
        private class Node
        {
            public int Data;
            public Node next;

            public Node(int data)
            {
                Data = data;
                next = null;
            }
        }

        static Node head;
        public bool IsEmpty()
        {
            return head == null;
        }

        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (IsEmpty())
            {
                head = newNode;
                return;
            }
            newNode.next = head;
            head = newNode;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                return -1;
            }
            int top = head.Data;
            head = head.next;
            return top;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                return -1;
            }
            return head.Data;
        }

    }
}
