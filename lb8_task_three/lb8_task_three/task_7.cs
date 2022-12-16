using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace lb8_task_three
{
    class task_7
    {
        #region task_7_one
        private int sportsmen_total_one = 0;
        private int sportsmen_total_two = 0;
        public void task_t_one_Sport()
        {
            WriteLine("14.	В двумерном массиве хранится информация о баллах, полученных\n спортсменами-пятиборцами в каждом из пяти видов спорта (в первой строке – информация \nо баллах первого спортсмена, во второй – второго и т.д.).\n Общее число спортсменов равно 20. Определить сколько баллов набрал \nспортсмен, занявший последнее место.");
            int[] sportsmen_one = new int[] { 1, 4, 3, 5, 2 };
            foreach (int i in sportsmen_one)
            {
                sportsmen_total_one += i;
            }

            int[] sportsmen_two = new int[] { 2, 5, 3, 4, 1 };
            foreach (int j in sportsmen_two)
            {
                sportsmen_total_two += j;
            }

            WriteLine("Первый спортсмен: " + sportsmen_total_one);
            WriteLine("Второй спортсмен: " + sportsmen_total_two);
        }

        #endregion

        #region task_7_two
       
        private int massive_average;
        private int massive_value;
        private int result;
        public void task_t_two()
        {
            WriteLine("14.	Найти координаты (номера) элемента, наиболее близкого \nк среднему значению всех элементов массива.");
            int[] massive = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //  massive_average = massive.Length();
            massive_value = int.MaxValue;
            //result = 0;
            for (int i = 0; i < massive.Length; i++)
            {
                if (Math.Abs(massive_average - massive[i]) < massive_value)
                {
                    massive_value = Math.Abs(massive_average - massive[i]);
                    result = massive[i];
                }
            }
            WriteLine(result);


        }
        #endregion
    }
}
