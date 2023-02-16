using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перегрузка_операции_homework_10._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            //matrix.Enter();
            //matrix.Print();
            //Matrix matrix2 = new Matrix();
            //matrix2.Enter();
            //matrix2.Print();
            //matrix *= 2;
            //matrix.Print();
            //if (matrix != matrix2) { Console.WriteLine("matrix != matrix2"); }
            //else { Console.WriteLine("matrix == matrix2"); }
            matrix[0, 0] = 100;
            matrix[2, 2] = 200;
            matrix.Print();
        }
    }
}