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

            List<int> NumList = new List<int>();
            NumList.Add(0);
            NumList.Add(1);
            NumList.Add(2);

            int x = NumList[0];
            int y = NumList[1];
            int z = NumList[2];

            foreach(int i in NumList)
            {
                Console.WriteLine(i);
            }

            NumList.RemoveAt(0);

            List<Point> PointList = new List<Point>();
            PointList.Add(Point1);
            PointList.Add(Point2);

            //Homework
            Console.WriteLine("Homework\n");
            List<char> CharList = new List<char>();
            CharList.Add('*');
            CharList.Add('#');
            CharList.Add('@');
            CharList.Add('%');
            foreach (char k in CharList)
            {
                Console.WriteLine(k);
            }

            Point Point3 = new Point(1, 1, '*');
            Point Point4 = new Point(2, 3, '#');
            Point Point5 = new Point(5, 8, '@');
            Point Point6 = new Point(6, 1, '%');

            List<Point> NewPointList = new List<Point>();
            NewPointList.Add(Point3);
            NewPointList.Add(Point4);
            NewPointList.Add(Point5);
            NewPointList.Add(Point6);

            Console.ReadLine();
        }
    }
}