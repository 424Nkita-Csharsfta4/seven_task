using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class tvelve_13
    {
        /*2. Описать класс Vector2 векторов на плоскости. Определить в нем: 
• конструктор, принимающий координаты вектора;
• копирующий конструктор;
• метод Length, возвращающий длину вектора;
• операции сложения и вычитания;
• операцию скалярного умножения вектора на вектор;
• операции умножения и деления на целое число; 
• метод для вывода вектора.
*/

        public void Otput_Vector()
        {

            Vector v1 = new Vector(1, 2, 3);
            Vector v2 = new Vector(4, 5, 6);
            Vector v3 = v1 + v2;
            Vector v4 = v1 - v2;
            double m = v2 * v3;
            double c = Vector.Cos(v1, v2);

            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3);
            Console.WriteLine(v4);
            Console.WriteLine(m);
            Console.WriteLine(c);
        }
    }
    class Vector
    {
        private double X;
        private double Y;
        private double Z;

        // конструктор без параметров 
        private Vector() { }

        //конструктор с параметрами
        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        //длина вектора
        public double GetLength()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        //операция сложения
        public static Vector operator +(Vector l, Vector r)
        {
            return new Vector(l.X + r.X, l.Y + r.Y, l.Z + r.Z);
        }

        //вычитание векторов
        public static Vector operator -(Vector l, Vector r)
        {
            return new Vector(l.X - r.X, l.Y - r.Y, l.Z - r.Z);
        }

        //вычисление скалярного произведения двух векторов
        public static double operator *(Vector l, Vector r)
        {
            return (l.X * r.X + l.Y * r.Y + l.Z * r.Z);
        }

        public static double Cos(Vector l, Vector r)
        {
            return (l * r) / (l.GetLength() * r.GetLength());
        }

        public override string ToString()
        {
            return string.Format("({0},{1},{2})", X, Y, Z);
        }
    }
}
