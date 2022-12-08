using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Collections;

namespace Vladislave
{
    class task_5
    {
        private int natur_c=0;
        private int natur_n;
        public void task_5_one()
        {
            WriteLine("Введите число: ");
            natur_n = int.Parse(ReadLine());
            int[] natur_chislo = { natur_n };
            for(int i = 0; i < natur_chislo.Length; i++)
            {
                if(natur_chislo[i] %2==1 && (i + 1) % 2 == 0)
                {
                    natur_c++;
                }
            }
            WriteLine(natur_c);
        }

        private static ArrayList Print_Mega_Gamumu;
        //private int natura_i = 0;
        private int natura_sum = 0;
        public void task_5_two()
        {
            Random rnd = new Random();
            Print_Mega_Gamumu = new ArrayList();
            for (int i = 0; i <= rnd.Next(10) + 1;)
            {
                Print_Mega_Gamumu.Add(rnd.Next(10));
                i++;
            }
            WriteLine("Посдовательность");
            foreach(int value in Print_Mega_Gamumu)
            {
                WriteLine(value + "  ");
                natura_sum += value;
            }
            WriteLine("Сумма всех элементов: " + natura_sum);
            WriteLine("Кол-во элементов " + Print_Mega_Gamumu.Count);

        }

        private int Max_coordinat = 0;
        private int Max_cena;
        
        public void task_5_three()
        {
            int[] cena_na_sugar = new int[10];
            Max_cena = int.MinValue;
            for(int i = 0; i <= 9; i++)
            {
                WriteLine("Введите цену канфеты: ",i+1);
                cena_na_sugar[i] = Convert.ToInt32(ReadLine());
                if(cena_na_sugar[i] > Max_cena)
                {
                    Max_cena = cena_na_sugar[i];
                    Max_coordinat = i;
                }
            }
            WriteLine("Номер самого дорогого вида конфет",Max_coordinat+1);
        }
    }
}
