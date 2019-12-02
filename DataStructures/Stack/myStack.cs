using System;
using DataStructures.SinglyLinkedList;

namespace DataStructures.Queue
{
    public class myStack<T>
    {
        private T Top
        {
            get
            {
                return ll.Head.Data;
            }
        }
        private mySinglyLinkedList<T> ll { get; set; }
        public bool IsEmpty
        {
            get
            {
                return ll.IsEmpty;
            }
        }
        public int Count
        {
            get
            {
                return ll.Count;
            }
        }

        public void Push(T data)
        {
            ll.Add(data);
        }

        public T Pop()
        {
            T popped = Top;
            ll.Delete(Top);
            return popped;
        }

        public T Peek()
        {
            return Top;
        }


        public myStack()
        {
            ll = new mySinglyLinkedList<T>();
        }
    }
}
