using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Змейка
{
    class Snake : Figura
    {
        Direction direction;//направление змейки
        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail); //удаляет хвост
            Point head = GetNextPoint();
            pList.Add(head);//добавляеь голову

            tail.Clear();//стирает хвост
            head.Draw();//выводит голову на экран
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();// текущая позиция головы из списка
            Point nextPoint = new Point(head);//создаём новую точку, которая явл-ся копие головы
            nextPoint.Move(1, direction);//смещает точку в голове на +1 по движению
            return nextPoint; //возврат
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)//если клавиша нажата влево
                direction = Direction.LEFT;//то змейка движется влево
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }
    }
}
