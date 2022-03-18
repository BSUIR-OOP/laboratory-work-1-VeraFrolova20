﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLR1
{
    class Rhombus: Parallelogram
    {
        public Rhombus(int x1, int y1, int x2, int y2, int x3, int y3) : base(x1, y1, x2, y2, x3, y3, x1, y2)
        {
            
        }
        public override string PrintName() { return "ромб"; }
        public override void PrintFigure()
        {
            Console.WriteLine( $"{PrintName()} с координатами противоположных углов A({x1},{y1}),B({x2},{y2}) \n");
        }
    }
}
