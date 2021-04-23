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
            int min1 = 100; // минимальный элемент первой строки
            int min3 = 100; // минимальный элемент третьей строки
            int tmpIndexI1 = 0;
            int tmpIndexI3 = 2;
            int tmpIndexJ1 = 0;
            int tmpIndexJ3 = 0;
            int tempElem;

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
            Console.WriteLine();

            for (int j = 0; j < column; j++)
            {
                if (min1 > A[tmpIndexI1, j])
                {
                    min1 = A[tmpIndexI1, j];
                    tmpIndexJ1 = j;
                }

                if (min3 > A[tmpIndexI3, j])
                {
                    min3 = A[tmpIndexI3, j];
                    tmpIndexJ3 = j;
                }
            }

            tempElem = A[tmpIndexI1, tmpIndexJ1];
            A[tmpIndexI1, tmpIndexJ1] = A[tmpIndexI3, tmpIndexJ3];
            A[tmpIndexI3, tmpIndexJ3] = tempElem;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{A[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            //* Составить программу, которая заполняет квадратную матрицу порядка n 
            //* натуральными числами 1, 2, 3, .. ., n2,записывая их в нее "по спирали" 
            //* против часовой стрелки.

            int n = 3, x = n - 1, y = n, d = -1, r = 9;
            int[,] a = new int[n, n];
            for (int i = 0; i < n; d *= -1)
            {
                for (int j = i; j < n; ++j)
                {
                    a[x, y += d] = r--;
                }
                for (int j = ++i; j < n; ++j)
                {
                    a[x += d, y] = r--;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }




            //* Найти в каждой строке матрицы координаты элемента, равного k(если он 
            //* там есть). Метод поиска - последовательный с барьером.

            int rowCount;
            int columnCount;
            string input;
            int tmp;
            Console.Write("Введите количество строк матрицы: ");
            input = Console.ReadLine();
            tmp = int.Parse(input);
            if (tmp < 1 || tmp > 20)
            {
                while (tmp < 1 || tmp > 20)
                {
                    Console.WriteLine("Введено неправильное число");
                    Console.Write("Попробуйте еще раз ввести количество строк матрицы: ");
                    input = Console.ReadLine();
                    tmp = int.Parse(input);
                }
            }
            rowCount = tmp;

            Console.Write("Введите количество столбцов матрицы: ");
            input = Console.ReadLine();
            tmp = int.Parse(input);
            if (tmp < 1 || tmp > 20)
            {
                while (tmp < 1 || tmp > 20)
                {
                    Console.WriteLine("Введено неправильное число");
                    Console.Write("Попробуйте еще раз ввести количество столбцов матрицы: ");
                    input = Console.ReadLine();
                    tmp = int.Parse(input);
                }
            }
            columnCount = tmp;
        }
    }
}
