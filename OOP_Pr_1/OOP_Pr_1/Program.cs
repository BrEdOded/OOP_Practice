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
            Point Point1 = new Point();
            Point1.x = 1;
            Point1.y = 3;
            Point1.Symbol = '*';
            Point1.DrawPoint();

            Point Point2 = new Point();
            Point2.x = 4;
            Point2.y = 5;
            Point2.Symbol = '#';
            Point2.DrawPoint();
        }
    }
}