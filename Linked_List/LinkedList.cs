using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    internal class LinkedList
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if(this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the Linked List", node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if(head == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            while(temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }

        }
    }

}
