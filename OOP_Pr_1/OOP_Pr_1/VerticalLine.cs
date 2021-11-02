using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Pr_1
{
    class VerticalLine : Figure
    { 
        public VerticalLine(int yHigh, int yDown, int x, char Symbol)
        {
            PointList = new List<Point>();
            for (int y = yHigh; y <= yDown; y++)
            {
                Point Point = new Point(x, y, Symbol);
                PointList.Add(Point);
            }
        }
    }
}
