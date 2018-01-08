using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTool
{

    public class Node
    {
        public Node Next;
        public object Value;
    }

    public class LinkedList
    {
        public Node head;
        private Node current;
        public int Count;

        public LinkedList()
        {
            head = new Node();
            current = head;
        }

        public void AddAtLast(object data)
        {
            Node newNode = new Node();
            newNode.Value = data;
            current.Next = newNode;
            current = newNode;
            Count++;
        }

        public void AddAtStart(object data)
        {
            Node newNode = new Node() { Value = data };
            newNode.Next = head.Next;
            head.Next = newNode;
            Count++;
        }

        public void RemoveFromStart()
        {
            if (Count > 0)
            {
                head.Next = head.Next.Next;
                Count--;
            }
            else
            {
                Console.WriteLine("No element exist in this linked list.");
            }
        }

        public void PrintAllNodes()
        {
            Console.Write("Head ->");
            Node curr = head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value);
                Console.Write("->");
            }
            Console.Write("NULL");
        }

        public object Find(int i)
        {
            int counter = 0;
            Node curr = head;
            while (curr.Next != null)
            {
                curr = curr.Next;

                if (counter == i)
                {
                    return curr.Value;
                }
                counter++;
            }
            return curr.Value;
        }
    }
}
