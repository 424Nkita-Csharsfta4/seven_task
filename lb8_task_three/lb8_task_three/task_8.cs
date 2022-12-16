using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace lb8_task_three
{
    class task_8
    {
        #region task_8_one
        private int array_m;
        private int array_n;
        private void Draw_Array(int[,] massive)
        {
            array_m = massive.GetLowerBound(0)+1;//методы для отображения границ 
            array_n = massive.GetUpperBound(1)+1;//одномерного и двумерного массива и отображения значений элементов массива
            for(int i = 0; i < array_m; i++)
            {
                for(int j = 0; j < array_n; j++)
                {
                    WriteLine(massive[i, j] + " ");
                }
            }
        }

        private int arrs_m = 4;
        private int arrs_n = 4;
        public void task_8_one()
        {
            Write("14.	Дан двумерный массив целых чисел. \nКо всем четным элементам массива прибавить последний элемент\n соответствующей строки, а к остальным – первый элемент соответствующего столбца.");
            Random random = new Random();
            int[,] Gamunkul = new int[array_m,array_n];
            for(int i = 0; i < array_m; i++)
            {
                for(int j = 0; j < array_n; j++)
                {
                    Gamunkul[i, j] = random.Next(0, 5);
                }
            }
            WriteLine("Вот массив: ");
            Draw_Array(Gamunkul);
            for(int i = 0; i < array_m; i++)
            {
                for(int j = 0; j < array_n; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Gamunkul[i, j] = 1;
                    }
                    else
                    {
                        if(j%2 == 0)
                        {
                            Gamunkul[i, j] += Gamunkul[i, array_n - 1];
                        }
                        else
                        {
                            Gamunkul[i, j] += Gamunkul[0, j];
                        }
                    }
                }
            }
            WriteLine("Пребразование массива: ");
            Draw_Array(Gamunkul);
            

        }
        #endregion

        #region task_8_two
        private int arg_x;
        public void task_8_two()
        {
            WriteLine("14.	Дан двумерный массив размером n*n , заполненный целыми числами. \nВсе его отрицательные элементы записать в одномерный массив.");
            int[,] Dvuxmerniy_arrr = { { 0,1,2},{ 3,4,5} };
            int[] massive = new int[Dvuxmerniy_arrr.GetLength(1)];
            for(int i = 0; i < Dvuxmerniy_arrr.GetLength(0); i++)
            {
                if (Dvuxmerniy_arrr[0, 1] < 0) { arg_x++; }
            }
            for(int i = 0; i < Dvuxmerniy_arrr.GetLength(0); i++) { massive[i] = arg_x; }
        }
        #endregion
    }
}
