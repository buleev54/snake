using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Змейка
{
    class FoodCreator
    {
        int mapWidht;// эти переменные хранит объект класса
        int mapHeight;
        char sym;

        Random random = new Random();

        public FoodCreator(int mapWidht, int mapHeight, char sym) //габариты карты. Эти переменный в качестве аргументов
        {
            this.mapWidht = mapWidht;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWidht - 2); //генерируем произвольные координаты в пределах карты
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, sym);//создаём точку с этими координатами
        }
    }
}
