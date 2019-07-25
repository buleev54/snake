using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Змейка
{
    class HorizontalLine
    {
        List<Point> pList;

        public HorizontalLine()  // коснтруктор, который будет вызываться присоздании линий
        {
            pList = new List<Point>();
            Point p1 = new Point(4, 4, '*');  //это лдля примера
            Point p2 = new Point(5, 4, '*');
            Point p3 = new Point(6, 4, '*');
            pList.Add(p1); //добавлячем все эти точки в список
            pList.Add(p2);
            pList.Add(p3);
        }

        public void Drow()// метод вызова этих точек на экран
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
