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
