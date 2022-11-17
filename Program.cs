using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class Node
    {
        /*Node class represents the node of doubly linked list
         * It consist of the information part and links to
         * its seccending and preceding nodes
         * in terms of next and previous nodes. */
        public int rollNumber;
        public string name;
        public Node next;/*points to the succeeding node*/
        public Node prev;/*points to the preceeding node*/
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
