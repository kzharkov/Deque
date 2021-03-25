using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    class Deque<T>
    {
        LinkedList<T> list;
        int size;

        public Deque()
        {
            list = new LinkedList<T>();
            size = 0;
        }

        public void AddFront(T item)
        {
            list.AddLast(item);
            size++;
        }

        public void AddTail(T item)
        {
            list.AddFirst(item);
            size++;
        }

        public T RemoveFront()
        {
            if (size == 0)
            {
                return default;
            }
            T item = list.Last.Value;
            list.RemoveLast();
            size--;
            return item;
        }

        public T RemoveTail()
        {
            if (size == 0)
            {
                return default;
            }
            T item = list.First.Value;
            list.RemoveFirst();
            size--;
            return item;
        }

        public int Size()
        {
            return size;
        }
    }

}