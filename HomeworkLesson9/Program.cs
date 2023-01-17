/*  
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


//   int sum(int m,int n)
// {  
//      if (m == n)
//         return m;
//      return sum(m,n - 1) + n;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"сумма чисел от {m} до {n} = [{sum(m,n)}] " );

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два 
неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


//    int A ( int m, int n)
// {   
//     if (m == 0) return  (n + 1);
//     if (m > 0 && n == 0) return  A(m - 1,1);
//     return  A (m - 1,  A(m, n - 1));
// }
// Console.Clear();
// Console.Write("Введите число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(A (m,n));



//дополнительные задачи

//  19 12 2022  СЕМИНАР


// int sum(int n, int m)
// {
//     if (m == 0)
//         return n;
//     return sum(n + 1, m - 1);
// }

// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(sum(n, m));



//   int rec(int n)
// {
//     if (n == 1)
//         return 1;
//     return rec(n - 1) + n;
// }


// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(n));


// если делать через процедуру


// void sum(int res)
// {
//     Console.WriteLine(1);
//     int x = Convert.ToInt32(Console.ReadLine());
//     res += x;
//     if (x == 0)
//         Console.WriteLine(res);
//     if (x != 0)
//         sum(res);
// }

// int res = 0;
// Console.Clear();
// sum(res);






/*
  Задача 63: Задайте значение N. Напишите программу, которая
выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

//   string rec(int n)
// {
//     if (n == 1)
//         return "1 ";
//     return rec(n - 1) + $"{n} ";
// }


// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(n));


// void rec(int n)
// {
//     if (n == 1)
//         Console.Write(n + " ");
//     if (n > 1)
//     {    
//         rec(n - 1);
//         Console.Write(n + " ");
//     }
// }


// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// rec(n);

/*
   Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"
*/


// string rec(int m, int n)
// {
//     if (n == m)
//         return $"{m} ";
//     return rec(m, n - 1) + $"{n} ";
// }


// Console.Clear();
// Console.Write("Введите число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(m, n));


/*   
Задача 67: Напишите программу, которая будет принимать на вход
число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/



//     int rec(int n)
// {    
//  ;
//     if (n % 10 == n || n < 10 || n / 10 == 0) // здесь для примера указана три варианта,для решения можно выбрать любой
//         return n;
//     return rec(n / 10) + n % 10;

// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(n));

/*
Задача 69: Напишите программу, которая на вход принимает два
числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

// int rec(int n, int m)
// {
//     if (m == 0)
//         return 1;
//     return rec(n, m - 1) * n;
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(n, m));


//незнаю что это

// void rec(string s2, string c)
// {
//     string s1;
//     int i;
//     if (s2.Length == 0)
//         Console.WriteLine(c);
//     else
//     {
//         for (i = 0; i < s2.Length; i++)
//         {
//             c += s2[i];
//             s1 = s2;
//             s1 = s1.Remove(i, 1);
//             rec(s1, c);
//             c = c.Remove(c.Length - 1, 1);
//         }
//     }
// }


// Console.Clear();
// string? s = Console.ReadLine(), c, s2;
// for(int i = 0; i < s.Length; i++)
// {
//     c = s[i].ToString();
//     s2 = s;
//     s2 = s2.Remove(i, 1);
//       //Console.WriteLine(s2);
//     rec(s2, c);
// }


/*  
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


//   int sum(int m,int n)
// {  

//     if (m == n)
//         return m;
//      Console.Write($"{n} ");   
//      return sum(m,n - 1) + n;

// }

// Console.Clear();
// Console.Write("Введите число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"сумма чисел от {m} до {n} = [{sum(m,n)}] " );

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два 
неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


//    int A ( int m, int n)
//  {   

//     if (m == 0) return  (n + 1);
//     else if (m > 0 && n == 0) return  A(m - 1,1);
//     else 
//     return  A (m - 1,  A(m, n - 1));
// }
// Console.Clear();
// Console.Write("Введите число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(A (m,n));

// ПОВТОР ЗАДАЧИ 68 

//          int F(int n, int m)
//         {
//             if(n < 0 || m < 0) Console.WriteLine("Введите неотр. числа");
//             if (n == 0) return m + 1;
//             if (n != 0 && m == 0) return F(n - 1, 1);
//             return F(n - 1, F(n, m - 1));
//         }

// Console.Clear();
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(F(m,n));

//ЗАДАЧИ С РЕШЕНИЕМ ОТ ДЕНИСА

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

/*
Дополнительная задача ПЕРЕСТАНОВКИ(https://acmp.ru/index.asp?main=task&id_task=350)
Дана строка, состоящая из N попарно различных символов. Требуется вывести все перестановки символов данной строки.

Входные данные
Входной файл INPUT.TXT содержит строку, состоящую из N символов (1 ≤ N ≤ 8), символы - буквы 
английского алфавита и цифры.

Выходные данные
В выходной файл OUTPUT.TXT выведите в каждой строке по одной перестановке. Перестановки можно выводить в 
любом порядке. Повторений и строк, не являющихся перестановками исходной, быть не должно.

Примеры
№	INPUT.TXT	              OUTPUT.TXT
1	AB	                      AB
                            BA 

2	
	
IOX                         XOI                           
                            OIX
                            IXO
                            XIO
                            OXI
                            IOX



*/

// void rec(string s2, string c)
// {
//     string s1;
//     int i;
//     if (s2.Length == 0)
//        Console.WriteLine(c);
//     else
//     {
//         for (i = 0; i < s2.Length; i++)
//         {
//             c += s2[i];
//             s1 = s2;
//             s1 = s1.Remove(i, 1);
//             rec(s1, c);
//             c = c.Remove(c.Length - 1, 1);
//         }
//     }
// }


// Console.Clear();
// string? s = Console.ReadLine(), c, s2;

// for(int i = 0; i < s.Length; i++)
// { 
//     c = s[i].ToString();
//     s2 = s;
//     s2 = s2.Remove(i, 1);
//        //Console.WriteLine(s2);
//     rec(s2, c);
// }


/*
я**Дополнительная задача ЗАПОЛНЕНИЕ ДИАГОНАЛЯМИ(**
[https://informatics.msk.ru/mod/statements/view.php?id=30010&chapterid=364#1]
(https://informatics.msk.ru/mod/statements/view.php?id=30010&chapterid=364#1)**)**

Объяснение: Если Вы распишете каждое значение на какой позиции оно стоит, то числа, которые стоят на 
одной диагонали имеют одинаковую сумма (i + j)
*/


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {  
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} \t");
//         Console.WriteLine();
//     }
// }


// Console.Clear();
// Console.Write("Введите размеры матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// int number = 1;

// for (int i = 1; i < matrix.GetLength(0) + matrix.GetLength(1) + 1; i++)
// {   
//   for (int j = 0; j < matrix.GetLength(0); j++)
//     {    
//         for (int k = 0; k < matrix.GetLength(1); k++)
//         {    
//             if (j + k + 1 == i)
//             {  
//              matrix[j, k] = number++;
//             }
//         }
//     }
// }
//  PrintMatrix(matrix);





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



//pate

// void rec(string s2, string c)
// {
//     string s1;
//     int i;
//     if (s2.Length == 0)
//        { Console.WriteLine( "c1 " +c);
//         Console.WriteLine(s2.Length); }
//     else
//     {
//         for (i = 0; i < s2.Length; i++)
//         {
//             c += s2[i];
//             s1 = s2;
//             s1 = s1.Remove(i, 1);
//             rec(s1, c);
//             c = c.Remove(c.Length - 1, 1);
//         }
//     }
// }


// Console.Clear();
// string? s = Console.ReadLine(), c, s2;

// for(int i = 0; i < s.Length; i++)
// { 
//     Console.WriteLine("S2 " +s.Length );
//  Console.WriteLine("S2 " +s[i] );
//     c = s[i].ToString();
//     s2 = s;
//     s2 = s2.Remove(i, 1);
//       Console.WriteLine( "s " +s);
//        Console.WriteLine( "s2 " +s2);
//        Console.WriteLine("c2 " +c);
//        Console.WriteLine("i " +i);
//     rec(s2, c);
// }
