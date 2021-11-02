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
            Point Point1 = new Point(1, 3, '*');
            Point1.DrawPoint();

            Point Point2 = new Point(4, 5, '#');
            Point2.DrawPoint();

            Console.ReadLine();
        }
    }
}