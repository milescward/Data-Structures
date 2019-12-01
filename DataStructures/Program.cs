using System;
using DataStructures.SinglyLinkedList;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new sgLinkedList();
            myList.Add(new Node(1));
            myList.Add(new Node(2));
            myList.Add(new Node(3));
            myList.Add(new Node(4));
            myList.Add(new Node(5));
            myList.Delete(3);
            Console.WriteLine(myList.Count);
            myList.Display();
        }
    }
}
