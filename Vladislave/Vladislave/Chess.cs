using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Vladislave
{
    class Chess
    {
        private int chess_k;
        private int chess_m;
        private int chess_l;
        private int chess_n;

        internal void peshka()
        {
            WriteLine("18. Пусть (k, l), (m, n) - поля шахматной доски: k,\n m - номера по горизонтали; l, n - номера по вертикали (l<k, m, n< 8).\n Определите можно ли с поля (k, l) попасть на поле (m, n) \nодним ходом пешки.");

            WriteLine("Введи натуральное число: ");
            chess_k  = int.Parse(ReadLine());
            WriteLine("Введи натуральное число: ");
            chess_m = int.Parse(ReadLine());
            WriteLine("Введи натуральное число: ");
            chess_l = int.Parse(ReadLine());
            WriteLine("Введи натуральное число: ");
            chess_n = int.Parse(ReadLine());
            if((chess_k + chess_l) %2 ==(chess_m + chess_n) % 2)
            {
                WriteLine("Поля одного цвета");
            }
            else
            {
                WriteLine("Поля разного цвета");
            }
        }
    }
}
