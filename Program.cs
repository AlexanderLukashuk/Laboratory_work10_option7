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
            int min1 = 0; // минимальный элемент первой строки
            int min3 = 0; // минимальный элемент третьей строки
            int index1;
            int index3;
            int tmpIndex1 = 0;
            int tmpIndex3 = 3;

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

            for (int j = 0; j < column; j++)
            {
                if (min1 < A[tmpIndex1, j])
                {
                    min1 = A[tmpIndex1, j];
                    index1 = j;
                }

                if (min3 < A[tmpIndex3, j])
                {
                    min3 = A[tmpIndex3, j];
                    index3 = j;
                }
            }

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (i == tmpIndex1)
                }
            }


            //* Составить программу, которая заполняет квадратную матрицу порядка n 
            //* натуральными числами 1, 2, 3, .. ., n2,записывая их в нее "по спирали" 
            //* против часовой стрелки.



            //* Найти в каждой строке матрицы координаты элемента, равного k(если он 
            //* там есть). Метод поиска - последовательный с барьером.
        }
    }
}
