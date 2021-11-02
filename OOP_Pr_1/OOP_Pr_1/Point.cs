using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Pr_1
{
    class Point
    {
        public int x;
        public int y;
        public char Symbol;
        public Point(int _x, int _y, char _Symbol)
        {
            x = _x;
            y = _y;
            Symbol = _Symbol;
        } 
        public Point(Point Point)
        {
            x = Point.x;
            y = Point.y;
            Symbol = Point.Symbol;
        }
        public void DrawPoint()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(Symbol);
        }
        public void Move(int OffSet, Direction Direction)
        {
            if(Direction == Direction.RIGHT)
            {
                x = x + OffSet;
            }
            else if(Direction == Direction.LEFT)
            {
                x = x - OffSet;
            }
            else if(Direction == Direction.UP)
            {
                y = y - OffSet;
            }
            else if (Direction == Direction.DOWN)
            {
                y = y + OffSet;
            }
        }
        public override string ToString()
        {
            return x + ", " + y + ", " + Symbol;
        }
        public void Clear()
        {
            Symbol = ' ';
            DrawPoint();
        }
        public bool IsHit(Point Point)
        {
            return Point.x == this.x && Point.y == this.y;
        }
    }
}
