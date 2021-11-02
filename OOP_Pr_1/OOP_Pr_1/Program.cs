using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_Pr_1
{
    class Program
    {
        static void Main()
        {
            Console.SetBufferSize(200, 50);

            //Отрисовка рамки
            HorizontalLine UpHorizontalLine = new HorizontalLine(0,78,0,'-');
            UpHorizontalLine.DrawLine();
            HorizontalLine DownHorizontalLine = new HorizontalLine(0, 78, 24, '-');
            DownHorizontalLine.DrawLine();
            VerticalLine LeftVerticalLine = new VerticalLine(0, 24, 0, '|');
            LeftVerticalLine.DrawLine();
            VerticalLine RightVerticalLine = new VerticalLine(0, 24, 78, '|');
            RightVerticalLine.DrawLine();

            //Отрисовка точек
            Point Point1 = new Point(4,5,'*');
            Point1.DrawPoint();

            //Отрисовка змейки
            Snake Snake = new Snake(Point1, 4, Direction.RIGHT);
            Snake.DrawLine();

            //Создание еды
            FoodCreator FoodCreator = new FoodCreator(80, 25, '$');
            Point Food = FoodCreator.CreateFood();
            Food.DrawPoint();

            //Перемещение змейки
            while(true)
            {
                if (Snake.Eat(Food))
                {
                    Food = FoodCreator.CreateFood();
                    Food.DrawPoint();
                }
                else Snake.Move();
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo Key = Console.ReadKey();
                    Snake.ChangeTheWay(Key.Key);
                }
                Thread.Sleep(200);
                Snake.Move();
            }
        }
    }
}