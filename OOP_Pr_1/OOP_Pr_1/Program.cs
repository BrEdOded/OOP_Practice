using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pr_1
{
    class Program
    {
        static void Main()
        {
            Console.SetBufferSize(120, 30);

            HorizontalLine UpHorizontalLine = new HorizontalLine(0,78,0,'-');
            UpHorizontalLine.DrawLine();
            HorizontalLine DownHorizontalLine = new HorizontalLine(0, 78, 24, '-');
            DownHorizontalLine.DrawLine();
            VerticalLine LeftVerticalLine = new VerticalLine(0, 24, 0, '|');
            LeftVerticalLine.DrawLine();
            VerticalLine RightVerticalLine = new VerticalLine(0, 24, 78, '|');
            RightVerticalLine.DrawLine();

            Point Point1 = new Point(3,3,'*');
            Point1.DrawPoint();

            Snake Snake = new Snake(Point1, 4, Direction.RIGHT);
            Snake.DrawLine();

            Console.ReadLine();
        }
    }
}