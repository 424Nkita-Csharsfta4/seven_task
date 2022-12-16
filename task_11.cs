using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Collections;

namespace lb8_task_three
{
    class task_11
    {
        public string Name_book { get; set; }
        public int Years_book { get; set; }
        public string Country_book { get; set; }
        public int Pages_book { get; set; }

        public void Books(string name, int year, string country,int page)
        {
            Name_book = name;
            Years_book = year;
            Country_book = country;
            Pages_book = page;
        }
        
        public void Otput_book()
        {
             Books("Справочник по C#", 2021, "Вильямс", 600);
             Books(" Радость программирования на PHP:",2020, "Алан Форбс",300);
             Books("Начало Node.js", 2019, "Басарат Али Сайед",700);
             Books("Паттерны объектно-ориентированного проектирования", 2018, "А.Слинкин", 400);
             Books("Чистый код", 2017, "Роберт Мартин", 834);
             Books("Чистая архитектура", 2022, "Роберт Мартин", 352);
             WriteLine("Название: {0} \nГод издания: {1} \nИздательство: {2} \nКоличество страниц: {3}",Name_book,Years_book,Country_book,Pages_book);
        }
    }
}
