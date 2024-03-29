﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_And_Algorithms
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        public Node<T> Top { get; private set; } = null!;
        public void Add(T value)
        {
            if(Top == null)
            {
                Top = new Node<T>(value);
            }
            else
            {
                Top.Add(value);
            }
        }
    }
}
