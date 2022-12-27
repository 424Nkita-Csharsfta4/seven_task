using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApp3
{
    class task_15
    {
        static string name, materialers, author, izdanie;
        static int price, age, iterate_cout = 0;
        static void Main(string[] args)
        {
            /*2.7. Создать абстрактный класс Товар с методом, 
             * позволяющим вывести на экран информацию о товаре.
             * Создать производные классы: Игрушка (название, цена, производитель, материал, возраст, на который рассчитана), 
             * Книга (название, автор, цена, издательство, возраст, на который рассчитана), 
             * Спорт-инвентарь (название, цена, производитель, возраст, на который рассчитан) 
             * со своими методами вывода информации на экран. Создать базу (массив) из n товаров, 
             * вывести полную информацию из базы на экран, а также организовать
             * поиск товаров, рассчитанных на определенный возраст. */
            ForegroundColor = ConsoleColor.Magenta;
            BackgroundColor = ConsoleColor.Yellow;

            WriteLine("Заполните БД товароми тоесть количество вывода на консоль товара: ");
            string tempers = ReadLine();
            int vvod = int.Parse(tempers);
            Tovar[] MongoDateBase = new Tovar[vvod];//Массив ссылок
            for (int i = 0; i < vvod; i++)
            {


                WriteLine("Введите тип товара: Игрушки,Книги,Спорт-Инвентарь");
                if (iterate_cout == 0)
                {
                    WriteLine("Если тип будет введен неверно, то по умолчанию будет использоватся \n тип товара Спорт-Инвентарь");

                    iterate_cout++;
                }
                tempers = ReadLine();
                if (tempers.Contains("Игрушки:"))
                {
                    WriteLine("Введите название: ");
                    name = ReadLine();
                    WriteLine("Введите возраст: ");
                    age = int.Parse(ReadLine());
                    WriteLine("Введите цену: ");
                    price = int.Parse(ReadLine());
                    WriteLine("Введите производителя: ");
                    izdanie = ReadLine();
                    WriteLine("Автор: ");
                    author = ReadLine();
                    WriteLine("Введите название материал: ");
                    materialers = ReadLine();
                    MongoDateBase[i] = new Toy(name, price, izdanie, materialers, age);
                    WriteLine("Инфа записана в БД");
                }
                else
                {
                    if (tempers.Contains("Книги:"))
                    {
                        WriteLine("Введите название книг: ");
                        name = ReadLine();
                        WriteLine("Введите автора: ");
                        author = ReadLine();
                        WriteLine("Введите цену: ");
                        price = int.Parse(ReadLine());
                        WriteLine("Введите издательство: ");
                        izdanie = ReadLine();
                        WriteLine("Кто автор: ");
                        author = ReadLine();
                        WriteLine("Введите возраст: ");
                        age = int.Parse(ReadLine());
                        MongoDateBase[i] = new Book(name, author, price, izdanie, age);
                        WriteLine("Инфа записана в БД");
                    }
                    else
                    {
                        WriteLine("Введите название:");
                        name = ReadLine();
                        WriteLine("Издание: ");
                        izdanie = ReadLine();
                        WriteLine("Введите цену:");
                        price = int.Parse(ReadLine());
                        WriteLine("Введите название производителя: ");
                        author = ReadLine();
                        WriteLine("Введите возраст: ");
                        age = int.Parse(ReadLine());
                        MongoDateBase[i] = new Sport(name, price, izdanie, author, age);
                        WriteLine("Инфа записана в БД");
                    }
                }
                WriteLine("Ваша База Даных MongoDB заполнена и выведина на экран:");
                for (int j = 0; j < vvod; j++)
                {
                    MongoDateBase[j].printer();
                    WriteLine();
                    WriteLine("Введите тип товара который вам нужен  тоесть: Игрушки, Книжки, Спорт-Инвентарь");
                    iterate_cout = 0;
                    for (int g = 0; g < vvod; g++)
                    {
                        if (MongoDateBase[i].type_tovar(tempers))
                        {
                            MongoDateBase[i].printer();
                            iterate_cout++;
                        }
                        if (iterate_cout == 0)
                        {
                            WriteLine("Такого типа товара нема в MongoDb");
                        }
                    }
                }
            }
        }

    }
    abstract class Tovar
    {
        abstract public void printer();//Ввод инфы
        abstract public bool type_tovar(string temp);//Проверка типа товара
    }
    class Toy : Tovar
    {

        string type = "Игрушки";
        public string Name;//Имя игрушки
        public int Price;//Товар
        public string Proizvoditel;//Производитель
        public string Material;//Материал
        public int Age;//Год

        public Toy(string name, int price, string proizvoditel, string material, int age)
        {
            this.Name = name;
            this.Price = price;
            this.Proizvoditel = proizvoditel;
            this.Material = material;
            this.Age = age;
        }
        public override void printer()//Модификатор override
                                      //требуется для
                                      //расширения или
                                      //изменения абстрактной
                                      //или виртуальной
                                      //реализации
                                      //унаследованного метода,
                                      //свойства, индексатора
                                      //или события.
        {
            WriteLine(" Тип товара:" + type + "Название " + Name + "Цена " + Price + "Производитель " + Proizvoditel + "Материал " + Material + "Возраст " + Age);
        }
        public override bool type_tovar(string temp)
        {
            return temp.Contains(type);
        }
    }
    class Book : Tovar
    {
        string type = "Книги";
        public string Name;//Имя книги
        public int Price;//Товар цена
        public string Izdanie;//Издатель
        public string Author;//Автор
        public int Age;//Год

        public Book(string name, string Izdanie, int price, string Author, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Izdanie = Izdanie;
            this.Price = price;
            this.Author = Author;
        }
        public override void printer()
        {
            WriteLine("Тип товара: \n" + type + "Название: \n" + Name + "Год: \n" + Age + "Издание: \n" + Izdanie + "Цена: \n" + Price + "Автор: \n" + Author);
        }
        public override bool type_tovar(string temp)
        {
            return temp.Contains(type);
        }
    }

    class Sport : Tovar
    {
        string type = "Спорт-Товар";
        public string Name;//Имя книги
        public int Price;//Товар цена
        public string Izdanie;//Издатель
        public string Author;//Автор
        public int Age;//Год
        public Sport(string name, int price, string Izdanie, string Author, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Izdanie = Izdanie;
            this.Price = price;
            this.Author = Author;
        }
        public override void printer()
        {
            WriteLine("Тип товара:" + type + "Название: " + Name + "Год " + Age + "Издание " + Izdanie + "Цена " + Price + "Автор " + Author);
        }
        public override bool type_tovar(string temp)
        {
            return temp.Contains(type);
        }
    }
}