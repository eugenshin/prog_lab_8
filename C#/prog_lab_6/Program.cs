using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            segments sm = new segments();
            Console.Write($"Введите количество сегментов от 1 до {segments.getmaxn()} и заполните их: ");//вызов статического метода
            sm.vvod();
            sm.totalvivod();
            Console.ReadLine();
        }
    }
}