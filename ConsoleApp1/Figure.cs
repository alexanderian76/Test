using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Figure
    {
        public double LengthSide(Point a, Point b) //Длина стороны 
        {
            double x, y;
            x = (double)(a.PointX - b.PointX);
            y = (double)(a.PointY - b.PointY);

            return Math.Sqrt(x * x + y * y);
        }
       public void PerimeterCalculator() // Считаем периметр и выводим какой у нас многоугольник
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double l = 0;
            Point[] arr = new Point[n];
            string name = n.ToString() + " - угольник";
            for (int i = 0; i < n; i++)
            {               
                Console.Write("Введите x ");                    //Вводим координаты точек 
                int x = Convert.ToInt32(Console.ReadLine());              
                Console.Write("Введите b ");  
                int y = Convert.ToInt32(Console.ReadLine());
                arr[i] = new Point(x, y, name);
                if (i != 0) l = l + LengthSide(arr[i], arr[i - 1]); 
                if (i == n-1) l = l + LengthSide(arr[i], arr[0]);
            }
            Console.WriteLine(name);
            Console.WriteLine("Периметр = {0}", l);
        }
    }
}
