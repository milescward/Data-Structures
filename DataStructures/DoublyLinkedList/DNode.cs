using System;
namespace DataStructures.DoublyLinkedList
{
    public class DNode<T>
    {
        public T Data { get; set; }
        public DNode<T> Next { get; set; }
        public DNode<T> Previous { get; set; }
        public DNode(T data)
        {
            this.Data = data;
        }
    }
}
