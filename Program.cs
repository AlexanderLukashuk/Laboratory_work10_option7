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

            int n = 3, a = n - 1, b = n, d = -1, r = 9;
            int[,] arr = new int[n, n];
            for (int i = 0; i < n; d *= -1)
            {
                for (int j = i; j < n; ++j)
                {
                    arr[a, b += d] = r--;
                }
                for (int j = ++i; j < n; ++j)
                {
                    arr[a += d, b] = r--;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }




            //* Найти в каждой строке матрицы координаты элемента, равного k(если он 
            //* там есть). Метод поиска - последовательный с барьером.

            int rowCount;
            int columnCount;
            int k;
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
            if (tmp < 1 || tmp > 100)
            {
                while (tmp < 1 || tmp > 100)
                {
                    Console.WriteLine("Введено неправильное число");
                    Console.Write("Попробуйте еще раз ввести количество столбцов матрицы: ");
                    input = Console.ReadLine();
                    tmp = int.Parse(input);
                }
            }
            columnCount = tmp;

            int[,] array = new int[rowCount, columnCount];

            Console.Write("Введине число: ");
            input = Console.ReadLine();
            k = int.Parse(input);

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    array[i, j] = random.Next(100);
                }
            }

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int last = array[rowCount - 1, columnCount - 1];
            array[rowCount - 1, columnCount - 1] = k;

            int x = 0;
            int y = 0;
            for (x = 0; x < rowCount; x++)
            {
                for (y = 0; y < columnCount; y++)
                {
                    if (array[x, y] == k)
                    {
                        tmp = array[x, y];
                        break;
                    }
                }

                if (tmp == k)
                {
                    break;
                }
            }
            array[rowCount - 1, columnCount - 1] = last;
            if ((x != (rowCount - 1) && y != (columnCount - 1)) || k == last)
            {
                Console.WriteLine($"[{x + 1}; {y + 1}]");
            }
            else
            {
                Console.WriteLine("Заданного элемента нет в матрице");
            }
        }
    }
}
