using System;
using System.Collections.Generic;
using System.Linq;
using Linked_List;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Linked List Programs!");
        LinkedList list = new LinkedList();
        list.Add(56);
        list.Add(30);
        list.Add(70);

        list.Display();
    }
}