using System;

namespace DataStructures.SinglyLinkedList
{
    public class sgLinkedList
    {
        private Node Head { get; set; }
        public int Count { get; private set; }

        public void Add(Node node)
        {
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
            Count++;
        }

        // Deletes the first occurance of a target in the linked list
        public void Delete(int target)
        {
            if (Head.Data == target)
            {
                Head = Head.Next;
            }

            Node iterator = Head;
            while (iterator != null)
            {
                if (iterator.Next.Data == target)
                {
                    iterator.Next = iterator.Next.Next;
                    Count--;
                    return;
                }
                iterator = iterator.Next;
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
    }
}
