using System;
using DataStructures.BinaryTree;

namespace DataStructures.SinglyLinkedList
{
    public class mySinglyLinkedList
    {
        private Node Head { get; set; }
        public int Count { get; private set; }
        public bool IsEmpty { get; private set; }

        private void AddNode(Node node)
        {
            if (Head == null)
            {
                Head = node;
                IsEmpty = false;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
            Count++;
        }

        public void Add(int data)
        {
            Node node = new Node(data);
            AddNode(node);
        }

        // Deletes the first occurance of a target in the linked list 
        public void Delete(int target)
        {
            if (Head.Data == target)
            {
                Head = Head.Next;
                Count--;
                return;
            }
            Node iterator = Head.Next;
            Node prev = Head;
            while (iterator != null)
            {
                if (iterator.Data == target)
                {
                    prev.Next = iterator.Next;
                    iterator.Next = null;
                    Count--;
                    if (Count == 0)
                    {
                        IsEmpty = true;
                    }
                    return;
                }
                iterator = iterator.Next;
                prev = prev.Next;
            }
            Console.WriteLine("Value not found in list");
        }

        public void Display()
        {
            Node iterator = Head;
            while (iterator != null)
            {
                Console.Write($"{iterator.Data} ->  ");
                iterator = iterator.Next;
            }
        }

        public mySinglyLinkedList()
        {
            IsEmpty = true;
        }
    }
}
