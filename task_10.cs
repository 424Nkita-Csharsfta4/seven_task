using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace lb8_task_three
{
    class task_10
    {
    }
    class Employee
    {
        public int number_mens { get; set; }
        public double Oklad { get; set; }

        public void Println(int number_mens, double Oklad)
        {
            this.number_mens= number_mens;
            this.Oklad = Oklad;
        }
        public void pretter() => WriteLine("Номер сотрудника = " + number_mens + "Оклад = "+Oklad);
    }
    class Production_Worker
    {
        private int number;
        public void Output()
        {
            Employee[] stankers = new Employee[3];
            Employee employee = new Employee();
            for(int i = 0; i < 3; i++)
            {
                WriteLine("Введите номер " + (i + 1) + " сотрудника");
                number = int.Parse(ReadLine());
                WriteLine("Его оклад");
                double salyarka = Convert.ToSingle(ReadLine());
                employee.Println(number, salyarka);
                stankers[i] = employee;
            }
            for(int i = 0; i < 3; i++) { stankers[i].pretter();}
        }
    }
}
