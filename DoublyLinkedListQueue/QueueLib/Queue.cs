using QueueLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLib
{
    public class LinkedQueue<T> : IQueue<T>
    {

        public DoubleLinkedList<T> List;
        public LinkedQueue()
        {
            List = new DoubleLinkedList<T>();
        }
        public LinkedQueue(T value)
        {
            List = new DoubleLinkedList<T>(new Node<T>(value));
        }
        public void Enqueue(T data)
        {
            List.AddLast(data);
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                return default;
            }
            return List.RemoveFirst();
        }

        public void Clear()
        {
            List.Clear();
        }

        public T Peek()
        {
            return List.GetLastAddedData();
        }

        public int Count()
        {
            Node<T> buff = List.Head;
            int count = 1;
            while (!buff.Equals(List.Tail))
            {
                count++;
                buff = buff.Next;

            }
            return count;
        }

        public bool IsEmpty()
        {
            return ((List.Head == null) && (List.Tail == null));
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = List.Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
