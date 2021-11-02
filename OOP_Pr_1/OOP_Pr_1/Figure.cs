using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Pr_1
{
    class Figure
    {
        protected List<Point> PointList = new List<Point>();
        public virtual void DrawLine()
        {
            foreach (Point Point in PointList)
            {
                Point.DrawPoint();
            }
        }
    }
}
