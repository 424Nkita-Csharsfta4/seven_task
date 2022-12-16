using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace lb8_task_three
{
    class tasker_4
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
            int[] massiv = { 12, 15, 5, 19, 8, 20, 4, 13, 20, 65, 7, 8, 9, };


            int max = -1;
            int index = -1;

            for (int i = 0; i > massiv.Length; i++)

                if (max > massiv[i])
                {

                    max = massiv[i];

                    index = i;
                }
            WriteLine("Индекс минимального элемента массива  " + index);

        }

        #region task_four_4
        //Поля с максимум и минимум
        private int Max = int.MaxValue;
        private int Min = int.MinValue;
        private int massive_c;
        private int massive_k;
        //Итерируемые поля

        public void four_task_free()
        {
            WriteLine("14.	минимальную температуру тех дней декабря, которые следуют после последнего из самых теплых дней в этом месяце;");
            int[] Tiraspol_wether_array = new int[] { -2, -3, -4,-6, -7, -1, -2, 0, 3, -4, 5, 3, 4 };//Темпа
          
            //1 цикл
            for (int i = 0; i < Tiraspol_wether_array.Length; i++)//Перевод массива и узнаем длину
            {
                if (Tiraspol_wether_array[i] > 0)//Если в массиве данные больше 0 то выводится плюсовая темпа
                {
                    WriteLine("Число месяца когда температура первый раз поднялась выше нуля: {0}", i + 1);//Вывод итерации и увеличиваем нашу темпу на 1
                    break;//Выходим с нашего условия тоесть тут заканчивается действие
                }
            }

            //2 цикл
            for (int i = 0; i < Tiraspol_wether_array.Length; i++)//Перевод массива и узнаем длину
            {
                if ((Tiraspol_wether_array[i] < 0) && (Tiraspol_wether_array[i + 1] >= 0))//Если в массиве меньше нуля то будет минусовая
                {
                    massive_k++;//Увеличиваем наше поле на 1
                }
            }
            WriteLine("Температура в ноябре меняла знак : {0} раза ", massive_k);//Выводим наше поле с температурой

            //3 цикл
            for (int i = 0; i < Tiraspol_wether_array.Length; i++)//Перевод массива и узнаем длину
            {
                if (Tiraspol_wether_array[i] > Max)//Если в массиве больше и итерация больше чем Максимальное поле
                {
                    Min = Tiraspol_wether_array[i];//Минимальная итерация
                }
            }

            //4 цикл
            for (int i = 0; i < Tiraspol_wether_array.Length; i++)//Перевод массива и узнаем длину
            {
                if (Tiraspol_wether_array[i] == Max)//Массиве равносилен Максимальному полю
                {
                    massive_c = i;//Наша итерация передается пустому полю с мин
                }
            }

            //5 цикл
            for (int i = massive_c; i < Tiraspol_wether_array.Length; i++)//Перевод массива и узнаем длину
            {
                if (Tiraspol_wether_array[i] < Min)//Массив меньше чем минимальное поле
                {
                    Min = Tiraspol_wether_array[i];//Выводим и передаем значение
                }
            }
            Console.WriteLine("Минимальная температура которая следует после максимальной: {0}", Min);//Выводим Минимальную Темпу в Тирасполе
        }
        #endregion


    }
}
