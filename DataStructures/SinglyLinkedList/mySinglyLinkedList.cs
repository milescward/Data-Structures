using System;
using System.Collections.Generic;
using System.Text;
using DataStructures.BinaryTree;

namespace DataStructures.SinglyLinkedList
{
    public class mySinglyLinkedList<T>
    {
        private Node<T> Head { get; set; }
        public int Count { get; private set; }
        public bool IsEmpty { get; private set; }

        //Adds a node to the front of the list
        private void AddNode(Node<T> node)
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

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            AddNode(node);
        }

        private bool Compare<T>(T x, T y)
        {
            return EqualityComparer<T>.Default.Equals(x, y);
        }
        // Deletes the first occurance of a target in the linked list 
        public void Delete(T target)
        {
            if (Compare(Head.Data, target))
            {
                Head = Head.Next;
                Count--;
                return;
            }
            Node<T> iterator = Head.Next;
            Node<T> prev = Head;
            while (iterator != null)
            {
                if (Compare(iterator.Data, target))
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

        //Displays the list as a string
        public string Display()
        {
            Node<T> iterator = Head;
            var sb = new StringBuilder();
            while (iterator != null)
            {
                sb.Append($"{iterator.Data} ->  ");
                iterator = iterator.Next;
            }
            return sb.ToString();
        }

        public mySinglyLinkedList()
        {
            IsEmpty = true;
        }
    }
}
