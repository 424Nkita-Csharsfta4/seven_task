using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Vladislave
{
    class R_4task_aray
    {
        public void four_task_one()
        {
            WriteLine("14.	Найти среднее арифметическое элементов массива целых чисел.");
            int[] numbers = { 5, 8, 12, -18, -54, 84, -35, 17, 37 };

            double average = 0;
            if (numbers.Length > 0)
            {
                double sum = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    sum += numbers[j];
                }

                WriteLine($"среднее арифметическое чисел равно:{average = sum / numbers.Length}");
            }
        }
        public void four_task_two()
        {

            int[] arrays = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int arraysSum = 0;

            for (int i = 0; i < arrays.Length; i++)
                arraysSum += arrays[i];

            WriteLine("сумма: {0}", arraysSum);
            WriteLine("среднее арефмитическое: {0}", arraysSum / arrays.Length);
        }

        private void Print(string name_mus,int[] mus_names){
            WriteLine("Ввод массива: ");
            for (int i = 0; i < mus_names.Length; i++)
            {
                WriteLine($"{name_mus}",i+1,mus_names[i]);
            }
      }
        public void four_task_free()
        {
            WriteLine("14.	минимальную температуру тех дней декабря, которые следуют после последнего из самых теплых дней в этом месяце;");
            int[] tempa_Tirasa = new int[31];
            Random rnd = new Random();
            for(int i = 0; i < tempa_Tirasa.Length; i++)
            {
                tempa_Tirasa[i] = rnd.Next(10) - 40;
            }
            Print("x", tempa_Tirasa);

            var min_tempa_Tirasa = tempa_Tirasa[0];
            var koval_tempa = 0;

            //Поиск холодного дня в Тирасполе
            for(var i = 0; i < tempa_Tirasa.Length; i++)
            {
                if(min_tempa_Tirasa > tempa_Tirasa[i])
                {
                    min_tempa_Tirasa = tempa_Tirasa[i];
                    koval_tempa = i;
                }
            }
            WriteLine("День имел наименьшую темпу: ",koval_tempa+1,tempa_Tirasa[koval_tempa]);

            //Сумма всех дней с темпой
            var sumers_temp = 0;
            for(int i = 0; i < koval_tempa; i++)
            {
                sumers_temp += tempa_Tirasa[i];
            }
            //Вывод результата о темпе
            if(koval_tempa == 0)
            {
                WriteLine("Самым холодным днем был ", koval_tempa + 1);
            }
            else
            {
                WriteLine("Средняя темпа до 0 дня",koval_tempa+1,sumers_temp/(koval_tempa+1));
            }
        }
    }
}
