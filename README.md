# seven_task
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
