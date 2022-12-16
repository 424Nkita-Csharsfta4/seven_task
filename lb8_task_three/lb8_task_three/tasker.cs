using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace lb8_task_three
{
    public class tasker
    {
        //2 Практическая
    
        #region taskers_one
        public void task_one()//Неявно типизированная локальная переменная 
        {
            WriteLine("Условие: Все трехзначные числа, в записи которых две одинаковые цифры;");
            for (int i = 100; i <= 199; i++)
            {
                int schet = i;
                int one = schet / 100;
                schet %= 100;
                int two = schet / 10;
                schet %= 10;
                int three = schet / 1;
                schet %= 1;
                if ((one == two || two == three || three == one))
                {
                    Console.WriteLine(i);
                }
            }
        }
        #endregion

        #region taskers_two
        public void task_two()
        {
            WriteLine("Условие: Вывести перамидку чисел:");
            for (int x = 0; x <= 3; x++)
            {
                for (int i = 0; i < x; ++i)
                {

                    Write(x);
                }
                WriteLine();
                for (int i = 0; i < x; ++i)
                {
                    Write(x + 5);
                }
                WriteLine();
            }
        }
        #endregion

        #region three //Зачтено
        private string yslovie;//Приватное поле строки

        public void Glavnoe()
        {
            yslovie = "Составить программудля графического отображения" +
                " чисел от 1 до n (значение m вводится с клавиатуры)." +
                "В каждой строке напечатать" +
                " очередное  число и столько символов +,сколько делителей у" +
                " этого числа." +
                "Например если n*4, то на экране должно быть" +
                " напечатано:1+ 2++ 3++ 4++";
            Console.WriteLine($"{yslovie}");

            WriteLine("Ведите количествострок: ");//Ввод количество строк
            var taskeers_str = int.Parse(Console.ReadLine());//Наше вводимое число
            string str = " ";//Пустая строка тоесть пробел
            for (var i = 1; i <= taskeers_str; i++)//Цикл обработки
            {
                str = str + "+";
                Console.Write(i + " " + str + '\n');//Табуляция
            }
        }
#endregion

    }


}
