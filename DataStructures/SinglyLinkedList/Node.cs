using System;
using System.Collections.Generic;

namespace DataStructures.SinglyLinkedList
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T data)
        {
            this.Data = data;
        }
    }
}
