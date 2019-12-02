using System;
using DataStructures.DoublyLinkedList;

namespace DataStructures.Queue
{
    public class myQueue<T>
    {
        private T Front
        {
            get
            {
                return dll.Head.Data;
            }
        }
        private T End
        {
            get
            {
                return dll.Tail.Data;
            }
        }
        private myDoublyLinkedList<T> dll { get; set; }
        public bool IsEmpty
        {
            get
            {
                return dll.IsEmpty;
            }
        }

        public int Count
        {
            get
            {
                return dll.Count;
            }
        }

        public void Enqueue(T data)
        {
            dll.AddBack(data);
        }

        public T Dequeue()
        {
            T dequeued = Front;
            dll.Delete(Front);
            return dequeued;
        }

        public T Peek()
        {
            return Front;
        }

        public myQueue()
        {
            dll = new myDoublyLinkedList<T>();
        }
    }
}
