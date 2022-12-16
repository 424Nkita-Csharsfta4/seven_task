using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace lb8_task_three
{
    class task_14
    {
        /*. Базовый класс: Автобус (поля: марка, количество мест, стоимость билета). 
            Метод: Общая стоимость всех мест. 
            Потомок: Туристический автобус (поле: стоимость экскурсии). 
            Изменения  в  потомке:  Общая  стоимость  всех  мест  с  учетом увеличения цены билета за экскурсию.
        */
    }
    class Autobus
    {
        private string Marka;
        private int Cout_mest;
        private double Price_poezdki;

        private void Sum_Full_many()// Метод: Общая стоимость всех мест. 
        {
            WriteLine($"{Marka} - {Cout_mest} - {Price_poezdki}");
        }
    }
    class Autobus_two : Autobus
    {
       
    }
}
