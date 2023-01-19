using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        public void AddAtEnd( int data)
        {
            Node node = new Node(data);
            if(head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                head = node;
                head.next = temp;
            }
            Console.WriteLine("{0} inserted into the Linked List", node.data);

        }

        public void Insert(int position, int data)
        {
            Node node = new Node(data);
            if (position < 1)
            {
                Console.WriteLine("Envalid Position");
            }
            else if(position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node temp = head;
                while (position > 2)
                {
                    temp = temp.next;
                    position--;
                }
                node.next = temp.next;
                temp.next = node;
            }
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
                Console.Write(temp.data + " > ");
                temp = temp.next;
            }

        }
        public void FirstDelete()
        {
            Node node = head;
            if (head != null)
            {
                node = head;
                head = head.next;
                node = null;
            }
        }
        public void LastDelete()
        {
            Node node = head;
            Node lastnode = node.next;
            if (head != null)
            {
                node = node.next;
                node.next = null;
                lastnode = null;
            }
        }
    }

}
