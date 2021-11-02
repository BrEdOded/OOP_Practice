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
        }
    }
}