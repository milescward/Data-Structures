using System;
using DataStructures.SinglyLinkedList;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var ll = new mySinglyLinkedList();
            ll.Add(1);
            ll.Add(2);
            ll.Add(3);
            Console.WriteLine(ll.Display());
        }
    }
}
