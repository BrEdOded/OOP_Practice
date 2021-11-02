using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Pr_1
{
    class HorizontalLine
    {
        List<Point> PointList;

        public HorizontalLine(int xLeft, int xRight, int y, char Symbol)
        {
            PointList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point Point = new Point(x, y, Symbol);
                PointList.Add(Point);
            }  
        }

        public void DrawLine()
        {
            foreach(Point Point in PointList)
            {
                Point.DrawPoint();
            }
        }
    }
}
