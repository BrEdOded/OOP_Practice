using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Pr_1
{
    class Figure
    {
        protected List<Point> PointList;
        public void DrawLine()
        {
            foreach (Point Point in PointList)
            {
                Point.DrawPoint();
            }
        }
    }
}
