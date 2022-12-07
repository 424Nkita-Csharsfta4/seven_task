using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Vladislave
{
    class Celie_Chisla
    {
        private int chislo_con;
        private int chislo_mod;
        private int chislo_div;
        private int chislo_ans;
        private int try_simple;
        internal void Chislo()
        {
            WriteLine("Даны целое число k ( ) и последовательность цифр 10110203…149159,\n в которой выписаны подряд все трехзначные числа от 101 до 150. \nОпределить k-ю цифру, если известно, что k – число, кратное трем.");
            chislo_con = int.Parse(ReadLine());
            chislo_mod = chislo_con % 3;
            chislo_div = chislo_con / 3;
            chislo_con = 101 + chislo_div;
            if(chislo_mod == 0)
            {
                chislo_ans = (chislo_con - 1) % 10;
            }
            else
            {
                if(chislo_mod == 1)
                {
                    chislo_ans = 1;
                }
                else
                {
                    if(chislo_mod == 2)
                    {
                        chislo_ans = (chislo_con / 10) % 10;
                    }
                    else
                    {
                        chislo_ans = chislo_con % 10;
                    }
                }
            }
            WriteLine($"Результат: {chislo_ans}");
        }
        internal void Natura()
        {
            WriteLine("Найти все трехзначные простые числа (простым называется натуральное число,\n большее 1, не имеющее других делителей, кроме единицы и самого \nсебя).");
            for (int a = 100; a <= 999; a++)
                if (try_simple < a)
                    Console.Write(a + " ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
