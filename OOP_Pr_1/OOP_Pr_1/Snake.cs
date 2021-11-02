using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Pr_1
{
    class Snake : Figure
    {
        public Snake(Point Tail, int Lenght, Direction Direction) 
        {
            //List<Point> PointList = new List<Point>();
            for (int i = 0; i < Lenght; i++)
            {
                Point Point = new Point(Tail);
                Point.Move(i, Direction);
                PointList.Add(Point);
            }
        }
    }
}
