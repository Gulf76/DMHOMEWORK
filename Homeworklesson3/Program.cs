﻿/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

     // //Console.Clear();
     // //Console.Write("Введите пятизначное число ");
     // //int n = Convert.ToInt32(Console.ReadLine());

     // // if ( n / 10000  == n % 10  &&  (n /1000) %10 == (n %100) /10 )
     // //    Console.Write ("Yes");
     // //  else 
     // //    Console.Write("No");

// Console.Clear();
// Console.Write("Введите пятизначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// while (n < 10000 || n > 99999)
// {
//     Console.Write("Вы ошиблись!\nВведите пятизначное число: ");
//     n = Convert.ToInt32(Console.ReadLine());
// }
// int n1 = n / 10000;
// int n2 = (n / 1000) % 10;
// int n4 = (n % 100) / 10;
// int n5 = n % 10;

// if (n1 == n5 && n2 == n4)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");

/* 
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

// Console.Write("Ведите координату X1: "); 
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Ведите координату Y1: "); 
// double y1 = Convert.ToDouble(Console.ReadLine()); 
// Console.Write("Ведите координату Z1: "); 
// double z1 = Convert.ToDouble(Console.ReadLine()); 
// Console.Write("Ведите координату X2: "); 
// double x2 = Convert.ToDouble(Console.ReadLine()); 
// Console.Write("Ведите координату Y2: "); 
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Ведите координату Z2: "); 
// double z2 = Convert.ToDouble(Console.ReadLine());
 
//  Console.WriteLine(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)));

/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

// Console.Clear();
//  int n = Convert.ToInt32(Console.ReadLine());

// for (int i = 1 ; i <= n ; i++)
// Console.Write ($"{Math.Pow(i,3)} ");
//Console.Write ($"{i*i*i} ");
