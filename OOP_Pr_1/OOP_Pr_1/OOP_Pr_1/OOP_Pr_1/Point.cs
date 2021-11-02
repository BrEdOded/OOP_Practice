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
        public Point()
        {
            //Console.WriteLine("Создается новая точка");
        }
        public Point(int _x, int _y, char _Symbol)
        {
            x = _x;
            y = _y;
            Symbol = _Symbol;
        }

        public void DrawPoint()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(Symbol);
        }
    }
}
