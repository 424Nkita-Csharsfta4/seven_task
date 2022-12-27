using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApp5
{
    class task_14
    {
        /*. Базовый класс: Автобус (поля: марка, количество мест, стоимость билета). 
             Метод: Общая стоимость всех мест. 
             Потомок: Туристический автобус (поле: стоимость экскурсии). 
             Изменения  в  потомке:  Общая  стоимость  всех  мест  с  учетом увеличения цены билета за экскурсию.
         */
        public void Vibor_Avtobusa()
        {
            Autobus autobus = new Autobus();
           
            Autobus_two autobus_Two = new Autobus_two();
            
            WriteLine("Выбери автобус тоесть 1 или 2: ");
            int key = int.Parse(ReadLine());
            switch (key)
            {
                case 1:
                    WriteLine("Выбрана 1 компания");
                    autobus.Sum_Full_many();
                    break;
                case 2:
                    WriteLine("Выбрана 2 компания");
                    autobus_Two.Sum_Full();
                    break;
            }
        }

    }
    class Autobus
    {
        private string Marka = "Mitsubishi";
        private int Cout_mest;
        private int Price_poezdki =6;
        

        public void Sum_Full_many()// Метод: Общая стоимость всех мест. 
        {
            WriteLine("Сколько мест хотите забронировать: ");
            Cout_mest = int.Parse(ReadLine());
            int cocos = Cout_mest * Price_poezdki;
            WriteLine($"Марка автобуса: {Marka}\nСтолько стоит один билет:{Price_poezdki}\nСтолько мест купил: {Cout_mest} \n Общяя стоимость всех мест:{cocos}");
        }
    }
    class Autobus_two : Autobus
    {
        private string Marka = "Т-62";
        private int Price_turist_poesdki = 8;
        private int mesta;
        public void Sum_Full()// Метод: Общая стоимость всех мест. 
        {
            WriteLine("Сколько мест хотите забронировать: ");
            mesta= int.Parse(ReadLine());
            int cocos_tur = mesta * Price_turist_poesdki;
            WriteLine($"Марка автобуса: {Marka}\nСтолько стоит один билет:{Price_turist_poesdki}\nСтолько мест купил:{mesta}\n Общяя стоимость всех мест:{cocos_tur}");
        }

    }
}
