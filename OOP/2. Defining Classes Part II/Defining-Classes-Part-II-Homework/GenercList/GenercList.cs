using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenercList
{
    class GenercList<T>
        where T: IComparable
    {
        private int count;
        private int capacity;
        private T[] list;
        //private List<T>
        public GenercList(int capacity)
        {
            list = new T[capacity];
            this.capacity = capacity;
            count = 0;
        }

        public int Count
        {
            get
            {
                return count;
            }
        }
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        public T this[int index]
        {
            get
            {
                if (index >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return this.list[index];
                }
            }
        }
        public void Add(T element)
        {
            list[count] = element;
            count++;
        }
        public void RemoveAt(int index)
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                for (int i = index + 1; i < count; i++)
                {
                    list[i - 1] = list[i];
                }
                count--;
            }
        }
        public void Insert(int index, T element)
        {
            if (count == capacity)
            {
                AutoGrow();
            }
            else
            {
                for (int i = index + 1; i <= count; i++)
                {
                    list[i] = list[i - 1];
                }
            }
        }
        public void Clear()
        {
            count = 0;
        }
        public int FindElement(T element)
        {
            int index = -1;
            for (int i = 0; i < count; i++)
            {
                if (list[i].Equals(element))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }   
        public T Min<T2>()
            where T2 : IComparable<T2>
        {
            if (count == 0)
            {
                throw new InvalidOperationException("Sequance contains no elements");
            }
            int min = 0;
            for (int i = 0; i < count; i++)
            {

                if ( list[min].CompareTo(list[i]) > 0 )
                {
                    min = i;
                }
            }
            return list[min];
        }

        private void AutoGrow()
        {
            T[] newList = new T[capacity * 2];
            for (int i = 0; i < capacity; i++)
            {
                newList[i] = list[i];
            }
            list = newList;
            capacity *= 2;
        }
    }
}
