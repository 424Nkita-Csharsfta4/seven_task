using System;
using System.Collections.Generic;
using System.Text;

namespace opros
{
    class task_26
    {
        //https://github.com/kolei/OAP/blob/master/articles/t3l1_3.md#Массивы-в-качестве-параметров
        private int max;
        private bool f_first;
        #region opros_2
        /*Теоретические опрос № 2

1. Общие принципы организации
инициализация.

Ввод-вывод элементов одномерного массива.
Типовые задачи на обработку одномерных массивов.

массивов. Одномерные массивы: объявление,

Двумерные массивы: объявление, инициализация. Ввод-вывод элементов двумерного
массива.

Типовые задачи на обработку двумерных массивов.
Оператор цикла Фогеасв.

Массивы трех и более измерений.

С АА 5

Определение метода. Вызов методов. Методы-процедуры и методы-функции.
Параметры методов. Необязательные параметры.

9. Передача параметров по ссылке и по значению. Выходные параметры.
10. Массивы в качестве параметров методов.

И. Методы с переменным числом параметров. Ключевое слово рагатз
12. Общая форма определения класса. Создание объектов класса.

13. Конструкторы по умолчанию. Создание конструкторов. Ключевое слово #15
14. Перегрузка методов.

15. Перегрузка конструкторов.
16. Модификаторы доступа.

17. Инкапсуляция. Свойства.
18. Массивы объектов.

19. Статические члены класса.
20. Статические классы.

21. Константы и поля для чтения.

22. Перегрузка операторов.

23. Основы наследования.

24. Конструкторы и наследование.

25. Полиморфизм и переопределение методов.

Абстрактные классы: определение, применение.*/
        #endregion

        private void task_1_26() //Общие принципы организации инициализация.
        {
            //В языке C# создание объекта класса осуществляется с помощью оператора new.
            //Во время создания, внутренние данные (переменные) класса могут быть инициализированы одним из следующих способов:
            //с помощью присваивания переменной класса нужного значения при ее
            //объявлении(непосредственная инициализация).
            //Этот способ используется только для переменных базовых типов.
            //Если нужно инициализировать объект класса, то используется инициализатор объектов;
        }
        private void task_2_26()//Ввод-вывод элементов одномерного массива.Типовые задачи на обработку одномерных массивов.
        {
            //В следующем примере кода показано, как создать одномерный массив целых чисел с элементами от 0 до 9:
            int[] arrayName = new int[10];

            //Создание и одновременно инициализация массива:
            int[] b = { 1, 2, 3, 4, 5 };

            //как использовать цикл for для итерации по массиву
            int[] oldNumbers = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < oldNumbers.Length; i++)
            {
                int number = oldNumbers[i];
            }

        }

        private void task_3_26()//Двумерные массивы: объявление, инициализация.
                                //Ввод-вывод элементов двумерногомассива.
        {
            Console.WriteLine("Введите размер матрицы");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int[,] mas = new int[x, y];
            Console.WriteLine("Заполни матрицу");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    mas[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        private void task_4_26()//Типовые задачи на обработку двумерных массивов.
                                //Оператор цикла Фогеасв.
        {
            // Заполним двумерный массив циклом
            int[,] Table = new int[3, 4];
            int row; // переменная для указания строк
            int col; // переменная для указания столбцов
            int x = 0; // Этой переменной будем заполнять элементы массива  

            for (row = 0; row < 3; ++row)
            {
                for (col = 0; col < 4; ++col)
                {
                    Table[row, col] = x; // Присваиваем значение элементу массива
                    x = x + 2;
                    Console.Write(" " + Table[row, col]);
                }
                Console.WriteLine();
            }
            //Оператор цикла foreach предназначен для перебора элементов коллекции или массива. 
            // объявить массив типа double, выделить память для массива
            double[] A = new double[10];
            Random rnd_num = new Random();

            // заполнить массив случайными числами в диапазоне от 0 до 20
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rnd_num.NextDouble() * 20;
            }
            foreach (int item in A)
            {
                if (f_first) // если первый элемент в массиве
                {
                    max = item; // то запомнить его
                    f_first = false;
                }
                else
                {
                    if (max < item)
                        max = item;
                }
            }
        }

        private void task_5_26()//Определение метода. Вызов методов. Методы-процедуры и методы-функции.
                                //Параметры методов.Необязательные параметры.
        {
            //Если переменные хранят некоторые значения, то методы содержат собой набор инструкций,
            //которые выполняют определенные действия. По сути метод - это именованный блок кода,
            //который выполняет некоторые действия.
        }

        private void task_6_26()//Передача параметров по ссылке и по значению. Выходные параметры.
        {
            //Существует два способа передачи параметров в метод в языке C#: по значению и по ссылке.
            //Наиболее простой способ передачи
            //параметров представляет передача по
            //значению, по сути это обычный способ передачи параметров:

            //Передача параметров по ссылке и модификатор ref
            //При передаче параметров по ссылке перед
            //параметрами используется модификатор ref:

        }

        private void task_7_26()//Массивы в качестве параметров методов.
        {
            //используя ключевое слово params,
            //мы можем передавать неопределенное количество параметров:
            //!
            //void Sum(params int[] numbers)
            //{
              //  int result = 0;
                //foreach (var n in numbers)
                //{
                  //  result += n;
                //}
                //Console.WriteLine(result);
            //}
            //int[] nums = { 1, 2, 3, 4, 5 };
            //Sum(nums);
            //Sum(1, 2, 3, 4);
            //!
            //Сам параметр с ключевым словом params
            //при определении метода должен представлять
            //одномерный массив того типа, данные которого мы
            //собираемся использовать. 
        }

        private void task_8_26()// Общая форма определения класса. Создание объектов класса.
        {
            //C# является полноценным объектно-ориентированным языком.
            //Это значит, что программу на C# можно представить в
            //виде взаимосвязанных взаимодействующих между собой объектов.
            //Описанием объекта является класс
            //, а объект представляет
            //экземпляр этого класса.Можно еще провести следующую аналогию.
        }

        private void task_9_26()//Конструкторы по умолчанию. Создание конструкторов. Ключевое слово
        {
            //C # создает его по умолчанию,
            //который создает экземпляр объекта
            //и присваивает переменным-членам значения
            //по умолчанию, перечисленные в таблице значений
            //по умолчанию. Конструктор без каких-либо параметров
            //называется конструктором по умолчанию. Другими словами,
            //этот тип конструктора не принимает параметры.
            //Недостатком конструктора по умолчанию является то,
            //что каждый экземпляр класса будет инициализирован одними
            //и теми же значениями, и невозможно инициализировать
            //каждый экземпляр класса разными значениями.
            /*class multiplication
{
    int a, b;
      
    // default Constructor
    public multiplication()   
    {
        a = 10;
        b = 5;
    }
  
// Main Method
public static void Main() {
      
    // an object is created, 
    // constructor is called
    multiplication obj = new multiplication(); 
      
    Console.WriteLine(obj.a);
    Console.WriteLine(obj.b);
      
    Console.WriteLine("The result of multiplication is: "
                                        +(obj.a * obj.b));
}
  
}*/
        }

        private void task_10_26()//Перегрузка методов
        {
            /*Иногда возникает необходимость создать один и тот же метод, но с разным набором параметров. И в зависимости от имеющихся параметров применять определенную версию метода. Такая возможность еще называется перегрузкой методов (method overloading).

И в языке C# мы можем создавать в классе несколько методов с одним и тем же именем, но разной сигнатурой. Что такое сигнатура? Сигнатура складывается из следующих аспектов:

Имя метода

Количество параметров

Типы параметров

Порядок параметров

Модификаторы параметров*/
        }

        private void task_11_26()// Перегрузка конструкторов.
        {
            //Как и методы, конструкторы также могут перегружаться.
            //Это дает возможность конструировать объекты самыми разными способами:

            /*
    class UserInfo
    {
        public string Name, Family;
        public byte Age;

        // Создадим несколько перегруженных конструкторов
        public UserInfo() { }
        public UserInfo(string Name)
        {
            this.Name = Name;
        }
        public UserInfo(string Name, string Family)
        {
            this.Name = Name;
            this.Family = Family;
        }
        public UserInfo(string Name, string Family, byte Age)
        {
            this.Name = Name;
            this.Family = Family;
            this.Age = Age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создадим несколько объектов типа UserInfo
            // используя перегруженные конструкторы
            UserInfo obj1 = new UserInfo();
            UserInfo obj2 = new UserInfo(Name: "Alex");
            UserInfo obj3 = new UserInfo(Name: "Alex", Family: "Erohin");
            UserInfo obj4 = new UserInfo(Name: "Alex", Family: "Erohin", Age: 26);
                        
            Console.ReadLine();
        }
    }*/
            /*Одна из самых распространенных причин
             * для перегрузки конструкторов заключается
             * в необходимости предоставить возможность
             * одним объектам инициализировать другие, 
             * наподобие того, как в предыдущем примере
             * инициализируются поля класса.*/

        }

        private void task_12_26()//Модификаторы доступа
        {
            /*Все поля, методы и остальные компоненты класса имеют модификаторы доступа. Модификаторы доступа позволяют задать допустимую область видимости для компонентов класса. То есть модификаторы доступа определяют контекст, в котором можно употреблять данную переменную или метод.

В языке C# применяются следующие модификаторы доступа:

private: закрытый или приватный компонент класса или структуры. Приватный компонент доступен только в рамках своего класса или структуры.

private protected: компонент класса доступен из любого места в своем классе или в производных классах, которые определены в той же сборке.

file: добавлен в версии C# 11 и применяется к типам, например, классам и структурам. Класс или структура с такми модификатором доступны только из текущего файла кода.

protected: такой компонент класса доступен из любого места в своем классе или в производных классах. При этом производные классы могут располагаться в других сборках.

internal: компоненты класса или структуры доступен из любого места кода в той же сборке, однако он недоступен для других программ и сборок.

protected internal: совмещает функционал двух модификаторов protected и internal. Такой компонент класса доступен из любого места в текущей сборке и из производных классов, которые могут располагаться в других сборках.

public: публичный, общедоступный компонент класса или структуры. Такой компонент доступен из любого места в коде, а также из других программ и сборок.*/
        }

        private void task_13_26()//Инкапсуляция. Свойства
        {
            //Инкапсуляция — это возможность (механизм
            //) с помощью которой мы
            //можем спрятать от конечного пользователя реализацию
            //того или иного метода, устройства объекта
            //и так далее и представить в пользование только то
            //Как обеспечивается инкапсуляция в C#
            // В C# для инкапсуляции используются
            // публичные (public) свойства и методы
            // объекта, а переменные (за очень редким исключением)
            // остаются закрытыми (private) от пользователя. 

            //Свойства
            //Кроме обычных методов в языке C#
            //предусмотрены специальные методы доступа,
            //которые называют свойства. Они обеспечивают
            //простой доступ к полям классов и структур, узнать
            //их значение или выполнить их установку.
            //Определение свойств Стандартное описание
            //свойства имеет следующий синтаксис:

            //Вначале определения свойства могут идти
            //различные модификаторы, в частности, модификаторы доступа.
            //Затем указывается тип свойства, после которого идет название свойства.
            //Полное определение свойства содержит два блока: get и set.
            // В блоке get выполняются действия по получению значения свойства.
            // В этом блоке с помощью оператора return возвращаем некоторое значение.
            //В блоке set устанавливается
            //значение свойства. В этом блоке с помощью параметра
            //value мы можем получить значение,
            //которое передано свойству.
            //Блоки get и set еще называются акссесорами
            //или методами доступа(к значению свойства), а также геттером и сеттером.
            /*class Person
  {
      private string name = "Undefined";

      public string Name
      {
          get
          {
              return name;    // возвращаем значение свойства
          }
          set
          {
              name = value;   // устанавливаем новое значение свойства
          }
      }
  }*/
        }

        private void task_14_26()//Массивы объектов.
        {
            //Массив представляет собой совокупность
            //переменных одного типа с общим для обращения к ним именем.
            //В C# массивы могут быть как одномерными, так и многомерными.
            //Массивы служат самым разным целям, поскольку они предоставляют удобные
            //средства для объединения связанных вместе переменных.
            //Массивами в C# можно пользоваться практически
            //так же, как и в других языках программирования.
            //Тем не менее у них имеется одна особенность: они реализованы в виде объектов.
        }

        private void task_15_26()//Статические члены класса.
        {
            // Кроме обычных полей, методов, свойств классы
            // и структуры могут иметь статические поля, методы, свойства.
            // Статические поля, методы, свойства относятся ко всему классу/
            // всей структуре и для обращения к подобным членам необязательно
            // создавать экземпляр класса / структуры.
            //Статические поля
           //Статические поля хранят состояние всего класса
           /// структуры.Статическое поле определяется как и обычное,
           /// только перед типом поля указывается ключевое слово static. 
           /// Например, рассмотрим класс Person, который представляет человека:
        }

        private void task_16_26()//Статические классы
        {
            //С точки зрения синтаксиса C# статический класс – это класс, который объявляется с ключевым словом static.

            //Общая форма объявления статического класса:

           // static class ClassName
        //{
            // поля и методы класса
            // ...
       // }
    }

        private void task_17_26()// Константы и поля для чтения.
        {
            //Константы классы
            //Кроме полей класс может определять для хранения
            //данных константы.В отличие от полей из значение устанавливается
            //один раз непосредственно при их объявлении и впоследствии не может
            //быть изменено.Кроме того, константы хранят некоторые данные, которые
            //относятся не к одному объекту, а ко всему классу в целом.
            /*Person tom = new Person();
tom.name = "Tom";
tom.Print();    // Person: Tom
 
Console.WriteLine(Person.type); // Person
// Person.type = "User";    // !Ошибка: изменить константу нельзя
 
class Person
{
    public const string type = "Person";
    public string name = "Undefined";
    public void Print() => Console.WriteLine($"{type}: {name}");
}*/
        }

        private void task_18_26()//Перегрузка операторов
        {
            /*Наряду с методами в классах и структурах мы можем также определять операторы. Например, пусть у нас есть следующий класс Counter:
class Counter
{
    public int Value { get; set; }
}*/
            //Данный класс представляет некоторый счетчик,
            //значение которого хранится в свойстве Value.

           // И допустим, у нас есть два объекта класса Counter
           // -два счетчика, которые мы хотим сравнивать или складывать
           // на основании их свойства Value, используя стандартные
           // операции сравнения и сложения:

//Counter counter1 = new Counter { Value = 23 };
  //          Counter counter2 = new Counter { Value = 45 };
           // bool result = counter1 > counter2;
            //Counter c3 = counter1 + counter2;
            //Но на данный момент ни операция сравнения, ни операция
            //сложения для объектов Counter не доступны.
            //Эти операции могут использоваться для ряда примитивных типов. 
        }

        private void task_19_26()//Основы наследования.
        {
            //Наследование (inheritance) является одним из
            //ключевых моментов ООП. Благодаря наследованию
            //один класс может унаследовать функциональность другого класса.
            //Пусть у нас есть следующий класс Person,
            //который описывает отдельного человека:
        }

        private void task_20_26()//Конструкторы и наследование.
        {
            /*Если конструктор определен только в
             * производном классе, то все происходит очень просто: 
             * конструируется объект производного класса, а базовая 
             * часть объекта автоматически собирается его конструктором,
             * используемым по умолчанию.

            Когда конструкторы определяются как в
            базовом, так и в производном классе, 
            процесс построения объекта несколько усложняется, 
            поскольку должны выполняться конструкторы обоих классов.
            В данном случае приходится обращаться к ключевому слову base, 
            которое находит двоякое применение: во-первых, для вызова конструктора 
            базового класса; и во-вторых, для доступа к члену базового
            класса, скрывающегося за членом производного класса.

            С помощью формы расширенного объявления
            конструктора производного класса и ключевого 
            слова base в производном классе может быть вызван 
            конструктор, определенный в его базовом классе. 
            Ниже приведена общая форма этого расширенного объявления:*/
        }

        private void task_21_26()// Полиморфизм и переопределение методов.
        {
            //При наследовании нередко возникает необходимость
            //изменить в классе-наследнике функционал метода, который
            //был унаследован от базового класса. В этом случае класс-наследник
            //может переопределять методы и свойства базового класса.

            //Те методы и свойства,
            //которые мы хотим сделать доступными
            //для переопределения, в базовом классе помечается
            //модификатором virtual. Такие методы и свойства называют
            //виртуальными.

            //А чтобы переопределить метод в
            //классе-наследнике, этот метод определяется с
            //модификатором override.
            //Переопределенный метод в классе-наследнике
            //должен иметь тот же набор параметров, ч
            //то и виртуальный метод в базовом классе.
        }

        private void task_22_26()//Абстрактные классы: определение, применение
        {
            //Кроме обычных классов в C# есть абстрактные классы.
            //Зачем они нужны? Классы обычно представляют некий план
            //определенного рода объектов или сущностей.
            //Например, мы можем определить класс Car для
            //преставления машин или класс Person для представления
            //людей, вложив в эти классы соответствующие свойства, поля,
            //методы, которые будут описывать данные объекты. Однако некоторые
            //сущности, которые мы хотим выразить с помощью языка программирования,
            //могут не иметь конкретного воплощения. Например, в реальности не существует
            //геометрической фигуры как таковой. Есть круг, прямоугольник, квадрат, но просто
            //фигуры нет. Однако же и круг, и прямоугольник имеют что-то общее и являются фигурами.
            //И для описания подобных сущностей, которые не имеют конкретного воплощения,
            //предназначены абстрактные классы.

          //  Абстрактный класс похож на обычный класс.
          //  Он также может иметь переменные, методы, конструкторы,
          //  свойства.Единственное, что при определении абстрактных классов
          //  используется ключевое слово abstract. Например, определим абстрактный
          //  класс, который представляет некое транспортное средство:
          
            /*
                    abstract class Transport
                      {
                      public void Move()
                     {
                   Console.WriteLine("Транспортно средство движется");
                      }
                   }
        Транспортное средство 
            представляет некоторую абстракцию, которая не
            имеет конкретного воплощения.То есть есть легковые
            и грузовые машины, самолеты, морские судна, кто-то на космическом
            корабле любит покататься, но как такового транспортного средства нет.
            Тем не менее все транспортные средства имеют нечто общее - они могут перемещаться.
            И для этого в классе определен метод Move, который эмулирует перемещение.
            Но главное отличие абстрактных классов от обычных состоит 
            в том, что мы НЕ можем использовать конструктор абстрактного
            класса для создания экземпляра класса. Например, следующим образом:
                        Transport tesla = new Transport();
                      }
            */
    }
}
