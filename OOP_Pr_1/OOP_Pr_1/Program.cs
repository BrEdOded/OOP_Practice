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
            /* Point Point1 = new Point(1, 3, '*');
             Point1.DrawPoint();

             Point Point2 = new Point(4, 5, '#');
             Point2.DrawPoint();*/

            int x = 1;
            Function1(x);
            Console.WriteLine("Call Function1 = " + x);

            x = 1;
            Function2(x);
            Console.WriteLine("Call Function2 = " + x);

            x = 1;
            Function3(x);
            Console.WriteLine("Call Function3 = " + x);

            Point Point1 = new Point(1, 3, '*');
            Move(Point1, 10, 10);
            Console.WriteLine("Call Move.Point1.x = " + Point1.x + ", Point1.y = " + Point1.y);

            Point Point2 = new Point(4, 5, '#');
            Point1 = Point2;
            Point2.x = 8;
            Point2.y = 8;
            Console.WriteLine("Point1 = Point2: Point1.x = " + Point1.x + ", Point1.y = " + Point1.y);

            Point1 = new Point(1, 3, '*');
            Update(Point1);
            Console.WriteLine("Call Move.Point1.x = " + Point1.x + ", Point1.y = " + Point1.y);

            Console.ReadLine();
        }
        public static void Function1(int Value)
        {

        }
        public static void Function2(int Value)
        {
            Value = Value++;
        }
        public static void Function3(int X)
        {
            X = X++;
        }
        public static void Move(Point Point, int dx, int dy)
        {
            Point.x = Point.x + dx;
            Point.y = Point.y + dy;
        }
        public static void Update(Point Point)
        {
            Point = new Point();
        }
    }
}