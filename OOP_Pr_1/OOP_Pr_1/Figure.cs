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

        internal bool IsHit(Figure figure)
        {
            foreach (var Point in PointList)
            {
                if (figure.IsHit(Point)) return true;
            }
            return false;
        }
        private bool IsHit(Point point)
        {
            foreach (var Point in PointList)
            {
                if (Point.IsHit(point)) return true;
            }
            return false;
        }
    }
}
