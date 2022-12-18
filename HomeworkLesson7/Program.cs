/***Задача 46:** Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
*/

// void InputMatrix(int[, ] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(-10, 11); 
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// string[] coord = Console.ReadLine().Split(" ");
// int row = int.Parse(coord[0]);
// int column = int.Parse(coord[1]);
// int[,] matrix = new int[row, column];
// InputMatrix(matrix);


// **Задача 50:** Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
// */

// void InputMatrix(int[, ] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 11); // [1, 10]
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// void ReleaseMatrix(int[, ] matrix, int x, int y)
// {
//     if (x >= matrix.GetLength(0) || y >= matrix.GetLength(1) || x < 0 || y < 0)
//         Console.WriteLine("К сожалению, Вы ошиблись в координатах");
//     else
//         Console.WriteLine(matrix[x, y]);
// }

// Console.Clear();
// Console.Write("Введите размеры матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[, ] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// Console.Write("Введите позицию элемента ");
// int[] coord = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// ReleaseMatrix(matrix, coord[0] - 1, coord[1] - 1);

/*
**Задача 52:** Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

// void InputMatrix(int[, ] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 11); 
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// void ReleaseMatrix(int[, ] matrix)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         double summa = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             summa += matrix[i, j];
//         }
//         Console.WriteLine($"Столбец {j + 1} = {summa / matrix.GetLength(0)}");
//     }
// }

// Console.Clear();
// Console.Write("Введите размеры матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[, ] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// ReleaseMatrix(matrix);