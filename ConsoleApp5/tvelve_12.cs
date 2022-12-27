using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class tvelve_12
    {

        //2 (с добавлением еще 3 полей)
        //2.	Ввести информацию по N параллелограммам
        //(поля: a, b – стороны параллелограмма,
        //α – угол между сторонами).
        //Определить количество квадратов, прямоугольников и ромбов.
        //Вывести список каждых.

        private double a;
        private double b;
        private double c;


        public void Vvod_Palelograma()//Метод принимающий ввод пользователя
        {
            Console.Write("Введите длину стороны a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите длину стороны b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Введите угол С: ");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("Площадь параллелограмма: " + Search_Ploshad(a, b, c));
            Console.WriteLine("Высота параллелограмма: " + Search_Ploshad(a, b, c) / a);
            Console.ReadKey();
        }
        static double Search_Ploshad(double a, double b, double c)//Поиск площяди
        {
            return a * b * Math.Sin(c * Math.PI / 180);
        }

    }
}
