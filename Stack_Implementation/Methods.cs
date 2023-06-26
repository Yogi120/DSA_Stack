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
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
                next = null;
            }
        }

        static Node head;
        public bool isEmpty()
        {
            return head == null;
        }

        public void push(int data)
        {
            Node newNode = new Node(data);
            if (isEmpty())
            {
                head = newNode;
                return;
            }
            newNode.next = head;
            head = newNode;
        } 
    }
}
