using System;
using DataStructures.SinglyLinkedList;

namespace DataStructures.DoublyLinkedList
{
    public class myDoublyLinkedList<T>
    {
        public DNode<T> Head { get; private set; }
        private DNode<T> Tail { get; set; }
        public int Count { get; private set; }
        public bool IsEmpty { get; set; }

        public void AddFront(T data)
        {
            var node = new DNode<T>(data);
            AddFront(node);
        }

        private void AddFront(DNode<T> node)
        {
            if (IsEmpty)
            {
                Head = node;
                Tail = node;
                Count++;
            }
            else
            {
                node.Next = Head;
                Head.Previous = node;
                Head = node;
                Count++;
            }
        }

        public void AddBack(T data)
        {
            var node = new DNode<T>(data);
            AddBack(node);
        }

        private void AddBack(DNode<T> node)
        {
            if (IsEmpty)
            {
                Head = node;
                Tail = node;
                Count++;
            }
            else
            {
                node.Previous = Tail;
                Tail.Next = node;
                Tail = node;
                Count++;
            }
        }
        
        public void Insert(DNode<T> node1, DNode<T> node2, T data)
        {
            if (node1 == null || node2 == null)
            {
                throw new NullReferenceException();
            }
            else if (node1.Next != node2)
                throw new InvalidOperationException();
            var node = new DNode<T>(data);
            node.Next = node2;
            node.Previous = node1;
            node1.Next = node;
            node2.Previous = node;
            Count++;
        }

        public void Insert(DNode<T> node1, T data)
        {
            if (node1 == null || node1.Next == null)
            {
                throw new NullReferenceException();
            }
            var node = new DNode<T>(data);
            node.Next = node1.Next;
            node.Previous = node1;
            node1.Next.Previous = node;
            node1.Next = node;
            Count++;
        }

        public myDoublyLinkedList()
        {
            this.IsEmpty = true;
        }
    }
}
