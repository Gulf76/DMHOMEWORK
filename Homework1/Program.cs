﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
 
 Console.Clear();
 Console.Write("Введите 1-ое число: ");
 int a = Convert.ToInt32(Console.ReadLine()); 
 Console.Write("Введите 2-ое число: ");
 int b = Convert.ToInt32(Console.ReadLine()); 

 if (a > b)
     {Console.Write("max= ");
     Console.WriteLine(a);
     Console.Write("min= ");
     Console.WriteLine(b); 
     }
 else if (a < b) 
     {Console.Write("max= ");
     Console.WriteLine(b);
     Console.Write("min= ");
     Console.WriteLine(a);
     }                
 else 
     {Console.Write("max=min= ");
     Console.WriteLine(a);
     } 

