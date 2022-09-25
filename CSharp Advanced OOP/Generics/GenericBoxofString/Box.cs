using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxOfString
{
    public class Box<T>
        where T : IComparable
    {
        public Box()
        {
            this.Items = new List<T>();
        }

        public List<T> Items { get; set; }

        public int CountGreaterThan(T itemToCompare)
        {
            int counter = 0;
            foreach (var item in Items)
            {
                if (item.CompareTo(itemToCompare) > 0)
                {
                    counter++;
                }
            }

            return counter;
        }

        public void Swap(int firstIndex, int secondIndex)
            => (Items[firstIndex], Items[secondIndex]) = (Items[secondIndex], Items[firstIndex]);
        //{
            //(Items[firstIndex], Items[secondIndex]) = (Items[secondIndex], Items[firstIndex]);

            //T item = Items[firstIndex];
            //Items[firstIndex] = Items[secondIndex];
            //Items[secondIndex] = item;
        //}

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    foreach (var item in Items)
        //    {
        //        sb.AppendLine($"{typeof(T)} : {item}");
        //    }

        //    return sb.ToString();
        //}

        public override string ToString() 
            => string.Join(Environment.NewLine, 
                Items.Select(x => $"{typeof(T)} : {x}"));
    }
}
