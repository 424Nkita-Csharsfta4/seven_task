# seven_task
````
  class tasker
    {
        private string yslovie;

        public void Glavnoe()
        {
            yslovie = "Составить программудля графического отображения" +
                " чисел от 1 до n (значение m вводится с клавиатуры).В каждой строке напечатать" +
                " очередное  число и столько символов +,сколько делителей у этого числа. " +
                "Например если n*4, то на экране должно быть напечатано:1+ 2++ 3++ 4++";
            Console.WriteLine($"{yslovie}");
          
            WriteLine("Ведите количествострок: ");
            int a = int.Parse(Console.ReadLine());
            string str = " ";
            for (int i = 1; i <= a; i++)
            {
                str = str + "+";
                Console.Write(i + "" + str + '\n');
            }
        }
    }
````
````
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Четырнадцатая_программа
{
class Program
{
static void Main(string[] args)
{
double x, y;
Console.Write("x = ");
double.TryParse(Console.ReadLine(), out x);
Console.Write("y = ");
double.TryParse(Console.ReadLine(), out y);
if ((x < -23 | y < 0)) Console.WriteLine("Да");
else if (x < -23 || y > 0) Console.WriteLine("Нет");
else Console.WriteLine("На границе");
Console.ReadLine();
}
}
}
````
```
 public  void task_three()
        {
            WriteLine("Введи бал от 1 до 4: ");
            var bal = int.Parse(ReadLine());
            if( bal <=100 && bal >= 90)
            {
                WriteLine("GOOD");
            }
            else
            {
                if(bal >= 70 && bal <= 48)
                {
                    WriteLine("Good-Maybe");
                }
                else
                {
                    if(bal > 50 && bal <= 69)
                    {
                        WriteLine("Ydovletvoritelno");
                    }
                    else
                    {
                        WriteLine("Ydovletvor");
                    }
                }
            }
        }
   ````
   ````
        public  void task_two()
        {
            Write("Введите число ");
            var a = int.Parse(ReadLine());
            if (a >= 100 && a < 1000)
            {
                var first = a / 100;
                var last = a % 10;
                if (first > last)
                   WriteLine("Первое больше ");
                if (first < last)
                    WriteLine("Последнее больше");
                if (first == last)
                    WriteLine("Числа равны");
            }
        }
        ````
