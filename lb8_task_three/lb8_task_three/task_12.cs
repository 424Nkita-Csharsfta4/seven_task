using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace lb8_task_three
{
    class task_12
    {
        //2 (с добавлением еще 3 полей)
        //2.	Ввести информацию по N параллелограммам
        //(поля: a, b – стороны параллелограмма,
        //α – угол между сторонами).
        //Определить количество квадратов, прямоугольников и ромбов.
        //Вывести список каждых.

        

        private double a;
        private double b;
        private double N;//Угол в радиусах

        private void  PARALELOGRAM_KAKOYTO_XZ(double a,double b,double N)
        {
            this.a = a;
            this.b = b;
            this.N = N;
        }
        public void Otput()
        {
            //WriteLine("Площядь: " , PARALELOGRAM_KAKOYTO_XZ() , Search_Ploshad());
            PARALELOGRAM_KAKOYTO_XZ(5, 10, 30);
        }

      

        private double Search_Ploshad()//Поиск площяди
        {
            return a * b * Math.Sin(N * Math.PI / 180);
        }

    }
}
