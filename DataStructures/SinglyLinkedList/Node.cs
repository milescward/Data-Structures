using System;


namespace DataStructures.SinglyLinkedList
{
    public class Node
    {
        public Node Next { get; set; }
        public int Data { get; set; }
        public Node(int data)
        {
            this.Data = data;
        }
    }
}
