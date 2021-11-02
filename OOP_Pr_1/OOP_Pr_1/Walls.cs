using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Pr_1
{
    class Walls
    {
        List<Figure> WallList;

        public Walls(int MapWitdh, int MapHeight)
        {
            WallList = new List<Figure>();

            //Отрисовка рамки
            HorizontalLine UpHorizontalLine = new HorizontalLine(0, MapWitdh-2, 0, '-');
            HorizontalLine DownHorizontalLine = new HorizontalLine(0, MapWitdh - 2, MapHeight-1, '-');
            VerticalLine LeftVerticalLine = new VerticalLine(0, MapHeight - 1, 0, '|');
            VerticalLine RightVerticalLine = new VerticalLine(0, MapHeight - 1, MapWitdh - 2, '|');

            WallList.Add(UpHorizontalLine);
            WallList.Add(DownHorizontalLine);
            WallList.Add(LeftVerticalLine);
            WallList.Add(RightVerticalLine);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var Wall in WallList)
            {
                if (Wall.IsHit(figure)) return true;
            }
            return false;
        }

        public void DrawWall()
        {
            foreach (var Wall in WallList) Wall.DrawLine();
        }
    }
}
