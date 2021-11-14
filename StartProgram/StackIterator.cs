using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StartProgram
{
    class StackIterator<T> : IEnumerator
    {
        private List<T> items;
        int index = 0;

        public StackIterator(List<T> items)
        {
            this.items = items;
        }

        public void Push(T item)
        {
            items.Add(item);       
        }

        public int Count()
        {
            return items.Count;
        }

        public void Pop()
        {
            items.Remove(items[items.Count - 1]);
        }
        public object Current => throw new NotImplementedException();

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

        public void PrintTwice()
        {
            for (int i = 0; i < 2; i++)
            {
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void Reset()
        {
            index = 0;
        }
    }
}
