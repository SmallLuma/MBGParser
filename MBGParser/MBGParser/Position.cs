﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBGParser
{
    public struct Position<T>
        where T : struct
    {
        public T X, Y;
    }
}
