using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QueueLib
{
    public class Node<T>
    {
        public Node(T Data)
        {
            this.Data = Data;
        }
        public T Data;
        public Node<T> Prev { get; set; }
        public Node<T> Next { get; set; }
    }


    public class DoubleLinkedList<T>
    {

        public Node<T> Head;

        public Node<T> Tail;

        public int count;

        public DoubleLinkedList(Node<T> node)
        {
            Head = Tail = node;
            count = 1;
        }
        public DoubleLinkedList()
        {
            Head = null;
            Tail = null;
            count = 0;
        }

        public void AddLast(T data)
        {
            var Node = new Node<T>(data);

            if (Head == null)
            {
                Head = Tail = Node;

            }
            else
            {
                Tail.Next = Node;
                Node.Prev = Tail;
            }
            Tail = Node;
            count++;

        }

        public void AddFirst(T data)
        {
            var Node = new Node<T>(data);
            var Temp = Head;
            Node.Next = Temp;
            Head = Node;

            if (count == 0)
            {
                Tail = Head;
            }
            else
            {
                Temp.Prev = Node;
            }
            count++;
        }

        public T RemoveLast()
        {
            var Node = Tail;
            var buff = Node.Data;
            if (Node.Prev == null)
            {
                Clear();
                return buff;
            }
            Tail = Node.Prev;
            return Node.Data;
        }

        public T RemoveFirst()
        {
            var Node = Head;
            var buff = Node.Data;
            if (Node.Next == null)
            {
                Clear();
                return buff;
            }
            Head = Node.Next;
            return buff;
        }

        public T GetLastAddedData()
        {
            return Tail.Data;
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            count = 0;
        }

    }
}
