using System;
using DataStructures.SinglyLinkedList;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var sll = new mySinglyLinkedList<int>();
            sll.Add(5);
            sll.Add(4);
            sll.Add(3);
            sll.Add(2);
            sll.Add(1);

            Console.WriteLine(sll.Display());
            sll.Reverse();
            Console.WriteLine(sll.Display());
        }
    }
}
