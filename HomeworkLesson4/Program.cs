/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
НЕ ИСПОЛЬЗОВАТЬ MATH.POW
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
// Console.Clear();
// Console.Write("Введите число a =  ");
// int a = Convert.ToInt32(Console.ReadLine()) ; 
// Console.Write("Введите число b =  ");
// int b = Convert.ToInt32(Console.ReadLine()) ; 
// int c = a;
//  for( int i = 1; i < b; i++ )
//      {
//         c = c * a;
//      }
// Console.Write($"Число с = {c}");



/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int p = 0;
// int sum = 0;
    
// while ( n / 10 != 0)
// {
//      p = n % 10;
//      n /=10; 
//      sum = sum + p;
// }
//    if ( n / 10 == 0)
// { 
//      p = n % 10 ;
//      sum = sum + p;
// }

// Console.WriteLine($"{sum} ");


/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов, предоставить возможность пользователю 
ввести числа и вывести их на экран.

1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]    
*/   

// Console.Clear();
// Console.Write("Введите число злементов в массиве  ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [] array = new int  [n] ;

// for ( int i = 0; i < array.Length; i++)
//      {
//      Console.Write("Введите число  ");
//      int x = Convert.ToInt32(Console.ReadLine());
//      array[i] = x ;
//      }
// Console.WriteLine($"[{string.Join(", ", array)}]"); 