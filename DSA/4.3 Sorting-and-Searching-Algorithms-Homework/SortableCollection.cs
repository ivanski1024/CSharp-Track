namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            for (int index = 0; index < this.Items.Count; index++)
            {
                if (this.Items[index].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public bool BinarySearch(T item)
        {
            return BinarySearch(item, 0, this.Items.Count - 1);
        }

        public void Shuffle()
        {
            int length = this.Items.Count;
            for (int index = 0; index < length; index++)
            {
                int randomIndex = index + GetRandomInt(0, length - index);
                T boof = this.Items[index];
                this.Items[index] = this.Items[randomIndex];
                this.Items[randomIndex] = boof;
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }

        private bool BinarySearch(T item, int startIndex, int endIndex)
        {
            if (startIndex == endIndex)
            {
                return this.Items[startIndex].Equals(item);
            }
            else
            {
                int centerIndex = startIndex + (endIndex - startIndex) / 2;

                int compareOutput = this.Items[centerIndex].CompareTo(item);
                if (compareOutput == 0)
                {
                    return true;
                }
                else if (compareOutput > 0)
                {
                    return BinarySearch(item, startIndex, centerIndex - 1);
                }
                else
                {
                    return BinarySearch(item, centerIndex + 1, endIndex);
                }
            }
        }

        private static int GetRandomInt(int start, int end)
        {
            return randomGenerator.Next(start, end);
        }

        private static readonly Random randomGenerator = new Random();
    }
}
