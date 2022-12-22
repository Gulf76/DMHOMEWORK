/*
  Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
  каждой строки двумерного массива.
*/

// 	void InputMatrix(int[,] matrix)
// 	{
// 	    for (int i = 0; i < matrix.GetLength(0); i++)
// 	    {
// 	        for (int j = 0; j < matrix.GetLength(1); j++)
// 	            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
// 	    }
// }


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} \t");
//         Console.WriteLine();
//     }
// }


// void ReleaseMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(1) - 1; k++)
//             {
//                 if (matrix[i, k] < matrix[i, k + 1])
//                 {
//                     int temp = matrix[i, k + 1];
//                     matrix[i, k + 1] = matrix[i, k];
//                     matrix[i, k] = temp;
//                 }
//             }
//         }
//     }
// }


// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// Console.WriteLine("Начальный двумерный массив: ");
// PrintMatrix(matrix);
// Console.WriteLine();
// ReleaseMatrix(matrix);
// Console.WriteLine("Конечный двумерный массив: ");
// PrintMatrix(matrix);

/*
Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
*/


// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(1, 11); // [1, 10]
//     }
// }


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} \t");
//         Console.WriteLine();
//     }
// }


// int ReleaseMatrix(int[,] matrix)
// {
//     int minRow = 0;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//         minRow += matrix[0, i];

//     for (int i = 1; i < matrix.GetLength(0); i++)
//     {
//         int sumRow = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sumRow += matrix[i, j];
//         }
//         if (minRow > sumRow)
//             minRow = sumRow;
//     }
//     return minRow;
// }


// Console.Clear();
// Console.Write("Введите размер прямоугольного двумерного массива: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// while (size[0] == size[1])
// {
//     Console.Write("Вы ошиблись!\nВведите размер прямоугольного двумерного массива: ");
//     size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// }
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// Console.WriteLine("Начальный двумерный массив: ");
// PrintMatrix(matrix);
// Console.WriteLine();
// Console.WriteLine($"Результат: {ReleaseMatrix(matrix)}");


/*
Задача 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/

// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i, j] = new Random().Next(1, 11); // [1, 10]
//     }
// }


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} \t");
//         Console.WriteLine();
//     }
// }


// int[,] ReleaseMatrix(int[,] FirstMatrix, int[,] SecondMatrix)
// {
//     int[,] result = new int[FirstMatrix.GetLength(0), FirstMatrix.GetLength(1)];
//     for (int i = 0; i < FirstMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < FirstMatrix.GetLength(1); j++)
//             result[i, j] = FirstMatrix[i, j] * SecondMatrix[i, j];
//     }
//     return result;
// }


// Console.Clear();
// Console.Write("Введите размер матриц: "); // размеры матриц должны быть одинаковые
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] FirstMatrix = new int[size[0], size[1]];
// int[,] SecondMatrix = new int[size[0], size[1]];
// InputMatrix(FirstMatrix);
// InputMatrix(SecondMatrix);
// Console.WriteLine("Начальный массив 1: ");
// PrintMatrix(FirstMatrix);
// Console.WriteLine("Начальный массив 2: ");
// PrintMatrix(SecondMatrix);
// Console.WriteLine("Результат:");
// PrintMatrix(ReleaseMatrix(FirstMatrix, SecondMatrix));


/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
построчно выводить массив, добавляя индексы каждого элемента.
*/

// void InputMatrix(int[,,] ThreeMatrix)
// {
//     int number = 10;
//     for (int i = 0; i < ThreeMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < ThreeMatrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < ThreeMatrix.GetLength(2); k++)
//                 ThreeMatrix[i, j, k] = number++; 
//         }
//     }
// }


// void PrintMatrix(int[,,] ThreeMatrix)
// {
//     for (int i = 0; i < ThreeMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < ThreeMatrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < ThreeMatrix.GetLength(2); k++)
//                 Console.WriteLine($"{ThreeMatrix[i, j, k]} ({i}, {j}, {k})");
//         }
//     }
// }


// Console.Clear();
// Console.Write("Введите размер трехмерного массива: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// while (size[0] * size[1] * size[2] > 90)
// {
//     Console.Write("Значения введены некорректные!\nВведите размер трехмерного массива: ");
//     size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// }
// int[,,] ThreeMatrix = new int[size[0], size[1], size[2]];
// InputMatrix(ThreeMatrix);
// PrintMatrix(ThreeMatrix);


/*
Задача 61(Дополнительная). Вывести первые N строк треугольник Паскаля. Сделать вывод в виде 
равнобедренного треугольника.
Статья
*/

// int factorial(int n)
// {
//     int i, x = 1;
//     for (i = 1; i <= n; i++)
//     {
//         x *= i;
//     }
//     return x;
// }


// void ReleaseTask(int n)
// {
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j <= (n - i); j++)
//         {
//             Console.Write(" ");
//         }
//         for (int j = 0; j <= i; j++)
//         {
//             Console.Write(" ");
//             Console.Write(factorial(i) / (factorial(j) * factorial(i - j)));
//         }
//         Console.WriteLine();
//     }
// }


// Console.Write("Введите количество строк треугольника Паскаля: ");
// int n = Convert.ToInt32(Console.ReadLine());
// ReleaseTask(n);

/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
*/

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {   
//             Console.Write(array[i, j] + " \t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Clear();
// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[size, size];
// int num = 1;
// int i = 0;
// int j = 0;

// while (num <= size * size)
// {
//     array[i, j] = num;
//     if (i <= j + 1 && i + j < size - 1)
//         j++;
//     else if (i < j && i + j >= size - 1)
//         i++;
//     else if (i >= j && i + j > size - 1)
//         j--;
//     else
//         i--;
//     num++;
// }
//  PrintArray(array);