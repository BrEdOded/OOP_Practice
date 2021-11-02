using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Pr_1
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char Symbol)
        {
            PointList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point Point = new Point(x, y, Symbol);
                PointList.Add(Point);
            }  
        }
        public override void DrawLine()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            //foreach (Point point in PointList) point.DrawPoint();
            base.DrawLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
