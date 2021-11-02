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
            // Первое п/з
            /*
             Console.WriteLine("Hello World!");
             Console.ReadLine();
            */

            // Второе п/з
            /*
            static void DrawPoint(int x, int y, char Symbol)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(Symbol);
            }
            int x = 1;
            int y = 3;
            char Symbol = '*';

            // Console.SetCursorPosition(x, y);
            // Console.Write(Symbol);
            DrawPoint(x, y, Symbol);

            int x1 = 4;
            int y1 = 5;
            char Symbol1 = '#';

            //Console.SetCursorPosition(x1, y1);
            //Console.Write(Symbol1);
            DrawPoint(x1, y1, Symbol1);
            */

            // Третье п/з
            /*
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
            */

            // Четвертое п/з
            /**/
            Point Point1 = new Point();
            /*Point1.x = 1;
            Point1.y = 3;
            Point1.Symbol = '*';*/
            Point1.DrawPoint();

            Point Point2 = new Point();
           /* Point2.x = 4;
            Point2.y = 5;
            Point2.Symbol = '#';*/
            Point2.DrawPoint();

        }
    }
}