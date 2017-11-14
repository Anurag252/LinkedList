using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList lnklist = new SinglyLinkedList();
            lnklist.AddNewNodeAtEnd("Hello");
            lnklist.AddNewNodeAtEnd("bye");
            lnklist.AddNewNodeAtEnd("bye1");
            lnklist.AddNewNodeAtEnd("bye2");
            lnklist.AddNewNodeAtEnd("bye3");
            lnklist.AddNewNodeAtEnd("bye4");
            lnklist.AddNewNodeAtEnd("bye5");
            lnklist.AddNewNodeAtEnd("bye6");
            lnklist.AddNewNodeAtEnd("bye7");
            lnklist.printAllNodes();
        }
    }
}
