using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab_6
{
    internal class segments
    {
        private const int MAXN = 100;//статическое поле
        private int n;
        private line[] ptrline = new line[MAXN];
        public void vvod()
        {
            while ((!int.TryParse(Console.ReadLine(), out n))||(n>MAXN)||(n<1))
                Console.WriteLine("Количество отрезков введено неверно.");
            for(int i = 0; i < n; i++)
            {
                ptrline[i] = new line();
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите координаты точек начала и конца отрезка {i}.");
                ptrline[i].vvod();
            }
        }
        public void totalvivod()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Отрезок {i}\n");
                ptrline[i].vivod();
                Console.WriteLine();
            }
        }
        public double totallength()
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += ptrline[i].length();
            }
            return sum;
        }
        
        public static int getmaxn()//статический метод
        {
            return MAXN;
        }
    }
}
