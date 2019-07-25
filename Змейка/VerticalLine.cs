using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Змейка
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int yTop, int yBottom, int x, char sym)  // коснтруктор, который будет вызываться присоздании линий
        {
            pList = new List<Point>();
            for (int y = yTop; y <= yBottom; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }

        public void Drew()// метод вызова этих точек на экран
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
