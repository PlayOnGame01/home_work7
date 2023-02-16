using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _.NET_homework_10._02
{
    internal class Matrix
    {
        private int[,] mas = new int[3, 3];
        public Matrix() { }
        public Matrix(int[,] mas)
        {
            this.mas = mas;
        }
        public void Enter()
        {
            WriteLine("Enter num for matrix:");
            string num = null;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    num = Console.ReadLine();
                    mas[i, j] = Convert.ToInt32(num);
                }
            }
            WriteLine();
        }
        public void Print()
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Write($"{mas[i, j]}  ");
                }
                WriteLine();
            }
            WriteLine();
        }
        public void MaxMinElement()
        {
            int max = 0, min = mas[0, 0];
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (max < mas[i, j]) { max = mas[i, j]; }
                    if (min > mas[i, j]) { min = mas[i, j]; }
                }
            }
            WriteLine($"Max element in matrix: {max}\nMin element in matrix: {min}");
        }
        public static Matrix operator +(Matrix obj1, Matrix obj2)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    obj1.mas[i, j] += obj2.mas[i, j];
                }
            }
            return obj1;
        }
        public static Matrix operator -(Matrix obj1, Matrix obj2)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    obj1.mas[i, j] -= obj2.mas[i, j];
                }
            }
            return obj1;
        }
        public static Matrix operator *(Matrix obj1, Matrix obj2)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    obj1.mas[i, j] *= obj2.mas[i, j];
                }
            }
            return obj1;
        }
        public static Matrix operator *(Matrix obj, int a)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    obj.mas[i, j] *= a;
                }
            }
            return obj;
        }
        public static bool operator ==(Matrix obj1, Matrix obj2)
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (obj1.mas[i, j] == obj2.mas[i, j]) { count++; }
                }
            }
            if (count == 9)
                return true;
            else
                return false;
        }
        public static bool operator !=(Matrix obj1, Matrix obj2)
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (obj1.mas[i, j] != obj2.mas[i, j]) { i = 3; j = 3; count = 10; }
                }
            }
            if (count == 10)
                return true;
            else
                return false;
        }
        public int this[int i, int j]
        {
            get => mas[i, j];
            set => mas[i, j] = value;
        }
    }
}