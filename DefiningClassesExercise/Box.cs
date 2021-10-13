using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClassesExercise
{
    public class Box<T>
        where T : IComparable
    {
        public Box()
        {
            this.Items = new List<T>();
        }

        public List<T> Items { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Items)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }

            return sb.ToString().TrimEnd();
        }

        public void Add(T item)
        {
            Items.Add(item);
        }

        public int CountGreaterThan(T item)
        {
            int count = 0;

            foreach (var currentItem in Items)
            {
                if(currentItem.CompareTo(item) > 0)
                {
                    count++;
                }               
            }
            return count;
        }

     
    }
}
