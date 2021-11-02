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
            int CountOfGame = 0;
           
            Console.SetBufferSize(120, 30);

            Walls Walls = new Walls(80, 25);
            Walls.DrawWall();

            //Отрисовка точек
            Point Point1 = new Point(4,5,'*');
            Point1.DrawPoint();

            //Отрисовка змейки
            Snake Snake = new Snake(Point1, 4, Direction.RIGHT);
            Snake.DrawLine();

            //Создание еды
            FoodCreator FoodCreator = new FoodCreator(80, 25, '$');
            Point Food = FoodCreator.CreateFood();
            Console.ForegroundColor = ConsoleColor.Green;
            Food.DrawPoint();

            //Перемещение змейки
            while(true)
            {
                if (Walls.IsHit(Snake) || Snake.IsHitTail())
                {
                    Console.SetCursorPosition(25, 26);
                    Console.WriteLine("GAME OVER!");
                    Console.ReadLine();
                    break; 
                }

                if (Snake.Eat(Food))
                {
                    Food = FoodCreator.CreateFood();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Food.DrawPoint();

                    CountOfGame++;
                    Console.SetCursorPosition(25, 25);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Count: " + CountOfGame);
                }
                else Snake.Move();
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo Key = Console.ReadKey();
                    Snake.ChangeTheWay(Key.Key);
                }
            }
        }
    }
}