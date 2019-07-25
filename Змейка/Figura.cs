using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Змейка
{
    class Figura
    {
        protected List<Point> pList;

        public void Drew()// метод вызова этих точек на экран
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
