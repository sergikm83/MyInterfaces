﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CloneablePoint.Classes
{
    // Теперь Point поддерживает способность клонирования
    public class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int xPos, int yPos) { X = xPos; Y = yPos; }
        public Point() { }

        public override string ToString() => $"X = {X}; Y = {Y}";

        public object Clone() => new Point(this.X, this.Y);
    }
}
