﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IInterface<T>
    {
        void Add(T obj);
        void Del(T obj);
        void Show();
    }
}
