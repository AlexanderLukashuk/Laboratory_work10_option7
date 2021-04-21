using System;

namespace Task10v7
{
    class Program
    {
        static void Main(string[] args)
        {
            //* В матрице А(3-строки,4-столбца) поменять местами наименьшие
            //* элементы в первой и третей строке.

            int row = 3;
            int column = 4;
            int[,] A = new int[row, column];
            Random random = new Random();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    A[i, j] = random.Next(100);
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{A[i, j]} ");
                }
                Console.WriteLine();
            }


            //* Составить программу, которая заполняет квадратную матрицу порядка n 
            //* натуральными числами 1, 2, 3, .. ., n2,записывая их в нее "по спирали" 
            //* против часовой стрелки.



            //* Найти в каждой строке матрицы координаты элемента, равного k(если он 
            //* там есть). Метод поиска - последовательный с барьером.
        }
    }
}
