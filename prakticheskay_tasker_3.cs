using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace lb8_task_three
{
    public class prakticheskay_tasker_3
    {
        //3 практическая
        #region one
        private int tasker_prakt;
        private int tasker_prakt_max =-1;
        private int tasker_prakt_min;

        public void praktics_one()
        {
            WriteLine("Дано натуральное число. Определить \n 14.на сколько его максимальная цифра превышает минимальную;");
            WriteLine("Ввиди число: ");
            tasker_prakt = int.Parse(ReadLine());
            for(int i =0;tasker_prakt != 0; i++)
            {
                if(tasker_prakt % 10 > tasker_prakt_max)//Делим наше вводимое число под  процент максимальное
                {
                    tasker_prakt_max = tasker_prakt % 10;
                    tasker_prakt_min = i;
                }
                tasker_prakt /= 10;
            }
            WriteLine($"Цифра - {tasker_prakt_max} максимальная,{tasker_prakt_min} минимальная цифра");
           

        }
        #endregion

        #region two
        private int foot_n;
        private int foot_never;
        private int foot_w;
        private int foot_f;
        private int foot_t;

      
        public void praktics_two()
        {
            WriteLine("14.Для каждой  команды-участницы чемпионата по \n" +
                " футболу известно ее количество \n" +
                "выигрышей и количество проигрышей.\n" +
                "Определить, сколько команд имеют \n" +
                "больше выигрышей, чем проигрышей?");

            Console.WriteLine("Введите количество игр: ");
            foot_n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < foot_n; i++)
            {
                Console.WriteLine("Введите количество очков полученных за " + (i + 1) + " игру: ");
                foot_t = Convert.ToInt32(Console.ReadLine());
                if (foot_t == 0) foot_f++;
                if (foot_t == 3) foot_w++;
                if (foot_t == 1) foot_never++;
            }
            Console.WriteLine("Количество ничьих: " + foot_never);
            Console.WriteLine("Количество побед: " + foot_w);
            Console.WriteLine("Количество поражений: " + foot_f);

        }
        #endregion

        #region free
        private double growth_man =  0;//Приватное поле 
        private double growth_women =0;//Приватное поле 
        private int col_people =0;

        public void praktics_three()
        {
            WriteLine("14.	Известен рост каждого студента университета.\n" +
                " Рост мальчиков условно задан отрицательными числами.\n" +
                "Определить, средний рост мальчиков и средний рост девочек\n");
            Console.Write("Сколько учащихся?: ");
            growth_man = int.Parse(Console.ReadLine());

            while (col_people++ <= growth_man)//Цикл проверяет 
            {
                Console.Write($"Рост {col_people} учащегося: ");
                growth_women += int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Средний рост = {growth_women / growth_man}");
            



        }
        #endregion

        #region four
        private double gamumu_a;
        public void Four()
        {
            WriteLine("Cos(x2)	п/3	3п/215");
            Console.Write("Вычисление sin(x)\nУгол в градусах вводим = ");
            gamumu_a= Convert.ToDouble(Console.ReadLine());
            double x, y;
            x = gamumu_a * Math.PI / 180;
            Console.WriteLine("Угол в радианах = {0}", x);
            y = Math.Sin(x);
            WriteLine("sin({0})={1}", x, y);
        }

        #endregion
    }

}
