using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pr_1
{
    class Snake : Figure
    {
        Direction Direction;
        public Snake(Point Tail, int Lenght, Direction _Direction) 
        {
            //List<Point> PointList = new List<Point>();
            Direction = _Direction;
            for (int i = 0; i < Lenght; i++)
            {
                Point Point = new Point(Tail);
                Point.Move(i, Direction);
                PointList.Add(Point);
            }
        }

        internal void Move()
        {
            Point Tail = PointList.First();
            PointList.Remove(Tail);
            Point Head = GetNextPoint();
            PointList.Add(Head);
            Tail.Clear();
            Head.DrawPoint();
        }
        public Point GetNextPoint()
        {
            Point Head = PointList.Last();
            Point NextPoint = new Point(Head);
            NextPoint.Move(1, Direction);
            return NextPoint;
        }
        public void ChangeTheWay(ConsoleKey Key)
        {
            if (Key == ConsoleKey.LeftArrow)
            {
                Direction = Direction.LEFT;
            }
            else if (Key == ConsoleKey.RightArrow)
            {
                Direction = Direction.RIGHT;
            }
            else if (Key == ConsoleKey.DownArrow)
            {
                Direction = Direction.DOWN;
            }
            else if (Key == ConsoleKey.UpArrow)
            {
                Direction = Direction.UP;
            }
        }

        internal bool Eat(Point Food)
        {
            Point Head = GetNextPoint();
            if (Head.IsHit(Food))
            {
                Food.Symbol = Head.Symbol;
                PointList.Add(Food);
                return true;
            }
            else return false;
        }
    }
}
