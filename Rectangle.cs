﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor3
{
    internal class Rectangle
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int GetArea()
        {
            return Length * Width;
        }
    }
}
