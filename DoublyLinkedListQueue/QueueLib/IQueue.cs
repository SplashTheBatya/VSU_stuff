using System;
using System.Collections;
using System.Collections.Generic;

namespace QueueLib
{
    public interface IQueue<T> : IEnumerable<T>
    {
        int Count();
        void Enqueue(T data);
        T Dequeue();
        T Peek();
        bool IsEmpty();
        void Clear();
    }
}
