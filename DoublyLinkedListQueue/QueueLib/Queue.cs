using QueueLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLib
{
    public class Queue<T> : IQueue<T>
    {
        public Queue()
        {
            List = new DoubleLinkedList<T>();
        }
        public DoubleLinkedList<T> List;

        
        public void AddLast(T data)
        {
            List.AddLast(data);
        }

        public void ClearQueue()
        {
            List.Clear();
        }

        public T GetData()
        {
            return List.GetLastAddedData();
        }

        public T RemoveFirst()
        {
            return List.RemoveFirst();
        }
    }
}
