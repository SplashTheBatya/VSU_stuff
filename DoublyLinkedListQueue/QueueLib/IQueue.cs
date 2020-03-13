using System;
using System.Collections;

namespace QueueLib
{
    public interface IQueue<T>
    {

        void AddLast(T data);

        T RemoveFirst();

        T GetData();

        void ClearQueue();
    }
}
