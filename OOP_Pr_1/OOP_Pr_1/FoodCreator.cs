using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pr_1
{
    class FoodCreator
    {
        int MapWidth;
        int MapHeigh;
        char Symbol;
        Random Random = new Random();
        public FoodCreator(int MapWidth, int MapHeigh, char Symbol)
        {
            this.MapWidth = MapWidth;
            this.MapHeigh = MapHeigh;
            this.Symbol = Symbol;
        }
        public Point CreateFood()
        {
            int x = Random.Next(2, MapWidth - 2);
            int y = Random.Next(2, MapHeigh - 2);
            return new Point(x, y, Symbol);
        }
            
    }
}
