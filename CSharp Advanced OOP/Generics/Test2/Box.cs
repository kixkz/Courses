﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{

    public class Box<T>
    {
        private List<T> internalList = new List<T>();

        public void Add(T item)
        {
            internalList.Add(item);
        }

        public T Remove()
        {
            T removedItem = internalList[internalList.Count - 1];
            internalList.RemoveAt(internalList.Count - 1);
            return removedItem;
        }

        public int Count => internalList.Count;
    }

}
