using System;
using System.Collections;

namespace QueueLib
{
    public interface IQueue<T> : IEnumerable
    {
        void AddFirst(T data);

        T RemoveLast();

        void ClearQueue();
    }
}
