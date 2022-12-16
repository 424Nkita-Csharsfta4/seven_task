using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace lb8_task_three
{
    class task_9
    {
        #region task_9_two
        private bool Burger(int b)
        {
            throw new NotImplementedException();
        }
        public void Legion_()
        {
            WriteLine(". Определить статический метод void Divisors (int n), который\n выводит на экран делители числа n.\n Используя этот метод, вывести на экран \nделители чисел:а) 11;б) 50;в) m(m вводится с клавиатуры).");
            for (int a = 50; a <= 70; a++)
            {
                int Chisburger = 0;
                for (int b = 2; b < a; b++)
                {
                    if (a % b == 0)
                    {
                        if (Burger(b))
                            Chisburger += b;
                    }
                }
                WriteLine(Chisburger);
            }

        }
        #endregion

        #region task_9_three
        private int Adolf_a = 1;
        private int Adolf_b = 2;
        private int Adolf_c = 3;
        private int Adolf_d = 4;
        public void three_nine()
        {
            WriteLine("3. Определить статический метод int Max(int a, int b, int c),\n который возвращает наибольшее из значений a, b, c. Используя этот метод,\n найти максимальное значение среди чисел:а) 5, 17, 9;\nб) 7, 15, 48;в) x, y, z(x, y, z  вводятся с клавиатуры).");
            int Maximaze_natura = Max(Max(Adolf_a,Adolf_b),Max(Adolf_c,Adolf_d));
        }
        private static int Max(int Ukrain, int Russian) => (Ukrain>Russian?Ukrain:Russian);
        #endregion
    }
}
