using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace lb8_task_three
{
    class task_5
    {
        #region task_5_one
        private int natur_c = 0;
        private int natur_n;
        public void task_5_one()
        {
            WriteLine("14.	Пусть даны натуральные числа п, а1, ..., ап.\n Определите количество членов ак последовательности а1, ...,\n ап являющихся нечетными числами.");
            WriteLine("Введите число: ");
            natur_n = int.Parse(ReadLine());
            int[] natur_chislo = { natur_n };
            for (int i = 0; i < natur_chislo.Length; i++)
            {
                if (natur_chislo[i] % 2 == 1 && (i + 1) % 2 == 0)
                {
                    natur_c++;
                }
            }
            WriteLine(natur_c);

        }
        #endregion

        #region task_two
        public void task_5_two()
        {
            WriteLine("14.	Напечатать все элементы, \n оканчивающиеся нулем");
            int[] a = new int[] { 330, 1340, 154, 4, 14, 1440 };
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 0 == 5) WriteLine(a[i]);
            }
        }
        #endregion


        #region task_two
        private int Max_coordinat = 0;
        private int Max_cena;
        public void task_5_three()
        {
            int[] cena_na_sugar = new int[10];
            Max_cena = int.MinValue;
            for (int i = 0; i <= 9; i++)
            {
                WriteLine("Введите цену канфеты: ", i + 1);
                cena_na_sugar[i] = Convert.ToInt32(ReadLine());
                if (cena_na_sugar[i] > Max_cena)
                {
                    Max_cena = cena_na_sugar[i];
                    Max_coordinat = i;
                }
            }
            WriteLine("Номер самого дорогого вида конфет", Max_coordinat + 1);
        }
        #endregion
    }
}
