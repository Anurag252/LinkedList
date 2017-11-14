using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLibrary
{
    class SinglyLinkedList
    {
        public Node head;
        public Node current;
        public int count;

       public SinglyLinkedList()
        {
            head = new Node();
            current = head;
        }

        public void AddNewNodeAtEnd(object data)
        {
            if (head.data == null)
            {
                
                head.data = data;
            }
            else
            {
                Node newNode = new Node();
                newNode.data = data;
                current.next = newNode;
                current = newNode;
                count++;
            }
        }

        public void printAllNodes()
        {
            Node dummy = head;

            while(dummy.next != null)
            {
                Console.Write(dummy.data.ToString());

                dummy = dummy.next;
                Console.Write("-->");

            }
            Console.Write(dummy.data.ToString());
        }
    }
}
