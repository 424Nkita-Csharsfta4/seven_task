using System;
using static System.Console;
namespace lb8_task_three
{
    class Program
    {
        static void Main(string[] args)
        {
           
            tasker task = new tasker();//Инициализация класса
            prakticheskay_tasker_3 pract = new prakticheskay_tasker_3();
            tasker_4 tasker_4 = new tasker_4();
           
            WriteLine("Выбери задачу от 1 до 10 Тут две практические 2 и 3 и 4");
            var taskers = int.Parse(ReadLine());
            switch (taskers) {
                case 1:
                    WriteLine("Задача номер 1");
                    task.task_one();
                    break;
                case 2:
                    WriteLine("Задача номер 2");
                    task.task_two();
                    break;
                case 3:
                    WriteLine("Задача номер 3");
                    task.Glavnoe();
                    break;
                case 4:
                    WriteLine("Задача номер 1 третей практической");
                    pract.praktics_one();
                    break;
                case 5:
                    WriteLine("Задача номер 2 третей практической");
                    pract.praktics_two();
                    break;
                case 6:
                    WriteLine("Задача номер 3 третей практической");
                    pract.praktics_three();
                    break;
                case 7:
                    WriteLine("Задача номер 4 третей практической");
                    pract.Four();
                    break;
                case 8:
                    tasker_4.four_task_one();
                    break;
                case 9:
                    tasker_4.four_task_two();
                    break;
                case 10:
                    tasker_4.four_task_free();
                    break;
                default:
                    WriteLine("Такой задачи нема");
                    break;
            }
        }
    }
}
