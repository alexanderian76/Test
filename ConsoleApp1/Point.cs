using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point
    {

        private int X;
        private int Y;
        private string Name;

        public Point() //Инициализация 
        {
            X = 0;
            Y = 0;
            Name = "O";
        }

        public Point(int x, int y, string name) //пользовательский конструктор
        {
            X = x;
            Y = y;
            Name = name;
        }

        public int PointX //Вернем координату X
        {

            get { return X; }
        }

        public int PointY //Вернем координату Y
        {

            get { return Y; }
        }

        public string NamePoint //Вернем имя
        {

            get { return Name; }
        }


    }
}
