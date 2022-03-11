using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab_6
{
    internal class point
    {
        private double x, y;
        private string discription = "Empty";

        public double X//свойства
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
                get { return y; }
                set { y = value; }
        }
        public string Discription {
            get { return discription; }
            set { discription = value; }
        }
        public void init(double x, double y)
        {//Использование this
            this.x = x;
            this.y = y;
        }
        public static point operator +(point a, point b)//перегрузка +
        {
            point c = new point();
            c.x = a.x + b.x;
            c.y = a.y + b.y;
            return c;
        }
        public static point operator ++(point a)//перегрузка ++
        {
            point b = new point();
            b.x = a.x + 1;
            b.y = a.y + 1;
            return b;
        }
        public void vvod()
        {
            while (!double.TryParse(Console.ReadLine(), out x))
                Console.WriteLine("Координата x введена неверно.");
            while (!double.TryParse(Console.ReadLine(), out y))
                Console.WriteLine("Координата y введена неверно.");
        }
        public void vivod()
        {
            Console.Write($"x={x}, y={y}");
        }
        public double distance(point sdpoint)
        {
            return Math.Sqrt(Math.Pow(sdpoint.x - x, 2) + Math.Pow(sdpoint.y - y, 2));
        }
        public double getx()
        {
            return x;
        }
        public double gety()
        {
            return y;
        }
    }
}
