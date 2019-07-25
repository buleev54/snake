using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Змейка
{
    class Point
    {
        public int x; //данные точек
        public int y;
        public char sym;

        public Point()//конструктор
        {           
        }

        public Point(int _x, int _y, char _sym) //конструктор для создания точек
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public void Draw()// метод вызова точек
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
