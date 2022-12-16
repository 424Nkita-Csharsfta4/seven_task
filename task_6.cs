using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace lb8_task_three
{
    class task_6
    {
        #region task_6_one
        private int sport_sum = 0;
        private int sport_max = 0;
        private int sport_num = 1;
        public void task_six_Gachi_muchi_sport_one()
        {
            WriteLine("14.	В двумерном массиве хранится информация о \nбаллах, полученных спортсменами-пятиборцами в каждом из пяти видов спорта \n(в первой строке – информация о баллах первого спортсмена, во второй – второго и т.д.). \nОбщее число спортсменов равно 20. Определить сколько баллов набрал \nспортсмен, занявший последнее место");
            int[,] sport_bol = new int[20, 5];
            for (int i = 0; i < 20; i++)
            {
                WriteLine("Введите данные спортсмена по номером " + (i + 1));
                for (int j = 0; j < 5; j++)
                {
                    WriteLine($"Введите данные по виду спорта номер ", (j + 1));
                    sport_bol[i, j] = int.Parse(ReadLine());
                }
            }
            for (int i = 0; i < 20; i++)
            {
                for (int g = 0; g < 20; g++)
                {
                    Write(sport_bol[i, g] + " ");
                }
            }
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    sport_sum += sport_bol[i, j];
                }
                if (sport_max < sport_sum)
                {
                    sport_max = sport_sum;
                    sport_num = i + 1;
                }
            }
            WriteLine("Максимум очков: " + sport_max + "У спортсмена" + sport_bol);
        }
        #endregion


        #region task_6_two
        private double seridina_close = 100;
        private double seridina_long = 100;
        private double seridina_test;
        private double[] masssiv;
        public void task_sixGachi_two()
        {
            WriteLine("14.	Найти координаты (номера) элемента, \nнаиболее близкого к среднему значению всех \nэлементов массива.");
            for (int i = 0; i < masssiv.Length; i++)
            {
                seridina_test = masssiv[i] - seridina_close;
                if (seridina_test < 0)
                {
                    seridina_test = seridina_test - (2 * seridina_test);
                }
                else
                {
                    seridina_test = masssiv[i] - seridina_close;
                }
                if (seridina_test < seridina_long)
                {
                    seridina_long = seridina_test;
                    seridina_close = masssiv[i];
                }
            }
        }
        #endregion

       
    }
    #region task_6_three
    class task_6_nomer_free
    {
        protected int matrica_m;//Для первого метода
        protected int matrica_n;//Для первого метода



        private void Printer_Matrica(int[,] massiv)
        {
            matrica_m = massiv.GetUpperBound(0) + 1;
            matrica_n = massiv.GetUpperBound(1) + 1;
            for (int i = 0; i < matrica_m; i++)
            {
                for (int j = 0; j < matrica_n; j++)
                {
                    WriteLine(massiv[i, j] + " ");
                }
            }
        }

        internal int matrica_glav_m = 4;//Для второга метода
        internal int matrica_glav_n = 4;//Для второга метода
        public void Glavnoe_Output()
        {
            Random random = new Random();
            int[,] massiv_two = new int[matrica_glav_m, matrica_glav_n];
            for (int i = 0; i < matrica_glav_m; i++)
            {
                for (int j = 0; j < matrica_glav_n; j++)
                {
                    massiv_two[i, j] = random.Next(0, 5);
                }
            }
            WriteLine("Исходный массив: ");

            Printer_Matrica(massiv_two);
            for (int i = 0; i < matrica_glav_m; i++)
            {
                for (int j = 0; j < matrica_glav_n; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        massiv_two[i, j] += massiv_two[i, matrica_glav_n - 1];
                    }
                    else
                    {
                        massiv_two[i, j] += massiv_two[0, j];
                    }
                }
            }
            WriteLine("Магия с массивом: ");
            Printer_Matrica(massiv_two);

        }
    }
    #endregion

    #region task_6_four
    class task_6_nomer_four
    {
        private void Sort_Rand_Ars(int[,] massiv)
        {
            Random random = new Random();
            for (int i = 0; i < massiv.GetLength(0); i++)
            {
                for (int j = 0; j < massiv.GetLength(1); j++)
                {
                    massiv[i, j] = random.Next(1, 10);
                }
            }
        }

        private void Sort_Rand_Ars_Print(int[,] dvux_massive)
        {
            for (int i = 0; i < dvux_massive.GetLength(0); i++)
            {
                for (int j = 0; j < dvux_massive.GetLength(1); j++)
                {
                    WriteLine($"{dvux_massive[i, j]}");
                }
            }
        }

        private int massive_m = 5;
        private int massive_n = 4;
        public void Fillter_arr()
        {
            int[,] massive_massivov = new int[massive_m, massive_n];
            Sort_Rand_Ars(massive_massivov);
            Sort_Rand_Ars_Print(massive_massivov);
        }
    }
    #endregion
}
