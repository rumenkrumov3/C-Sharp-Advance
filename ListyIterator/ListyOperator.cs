using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListyOperator<T> : IEnumerator<T>
    {
        private List<T> items;
        int index = 0;
        public ListyOperator(List<T> list)
        {
            this.items = list;
        }

        public T Current => items[index];

        object IEnumerator.Current => Current;        

        public bool MoveNext()
        {
            index++;

            if (index < items.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Print()
        {
            Console.WriteLine(items[index]);
        }

        public bool HasNext()
        {
            if (index < items.Count - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintAll()
        {
            Console.WriteLine(string.Join(" ", items));
        }

        public void Reset()
        {
            index = 0;
        }

        public void Dispose()
        {

        }
    }
}
