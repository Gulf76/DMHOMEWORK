/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

// void InputArray (int[] array )
// {
//      for ( int i = 0; i < array.Length; i++)
//      array[i] = new Random().Next(100, 1000); 
// }
 
//  int EvenNumbers (int[] array )
//  {
//       int count = 0 ;
//       for ( int i = 0; i < array.Length; i++)
//       {
//           if (array[i] % 2 == 0)
//           count++;
//       }
//       return count;
//  }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
// Console.WriteLine($"Kоличество чётных чисел: [{EvenNumbers(array)}]");

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих 
на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

// void InputArray (int[] array )
// {
//      for ( int i = 0; i < array.Length; i++)
//      array[i] = new Random().Next(100, 1000); 
// }
 
//  void OddSum (int[] array )
//  {
//       int sum = 0 ;
//       for ( int i = 0; i < array.Length; i++)
//       {
//           if (i % 2 == 1)
//           sum += array[i] ;
//       }
//       Console.WriteLine($"Сумма элементов, на нечётных позициях: [{sum}]");
//  }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
// OddSum(array);
 
/*
 Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

// void InputArray (double[] array )
// {
//      Random rand = new Random();
//      for ( int i = 0; i < array.Length ; i++)
//      array[i] = rand.Next(-5, 5) + Math.Round(rand.NextDouble(),1);
     
// }
//   void MaxMin ( double[] array) 
//   {
//     for ( int i = 0; i < array.Length-1; i++) 
//     { int MinPos = i;
    
//           for ( int j = i + 1; j < array.Length; j++)
//                 {
//                   if ( array [j] <  array [MinPos]) MinPos = j; 
//                 }  
//                       double temp = array [i] ;
//                       array [i] = array [MinPos] ;
//                       array [MinPos] =  temp;
                      
//     }
//   }


// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[n];
// InputArray(array);
// Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
// MaxMin(array);
// Console.WriteLine($"Текущий массив:  [{string.Join(", ", array)}]");
// Console.WriteLine($"Разность max и min: [{array[array.Length-1] - array[0]}]");


/*
Вася не любит английский язык, но каждый раз старается получить хотя бы четверку за четверть, чтобы оставаться 
ударником. В текущей четверти Вася заметил следующую закономерность: по нечетным дням месяца он получал тройки, а 
по четным – четверки. Так же он помнит, в какие дни он получал эти оценки. Поэтому он выписал на бумажке все эти дни 
для того, чтобы оценить, сколько у него троек и сколько четверок. Помогите Васе это сделать, расположив четные и 
нечетные числа в разных строчках. Вася может рассчитывать на оценку 4, если четверок не меньше, чем троек.
Входные данные
В первой строке входного файла INPUT.TXT записано единственное число N – количество элементов целочисленного 
массива (1 ≤ N ≤ 100). Вторая строка содержит N чисел, представляющих заданный массив. Каждый элемент массива – 
натуральное число от 1 до 31. Все элементы массива разделены пробелом.

Выходные данные
В первую строку выходного файла OUTPUT.TXT нужно вывести числа, которые соответствуют дням месяцев, в которые 
Вася получил тройки, а во второй строке соответственно расположить числа месяца, в которые Вася получил четверки. 
В третьей строке нужно вывести «YES», если Вася может рассчитывать на четверку и «NO» в противном случае. 
В каждой строчке числа следует выводить в том же порядке, в котором они идут во входных данных. При выводе числа 
отделяются пробелом
*/




// void InputArray (int[] array )
// {
//      for ( int i = 0; i < array.Length; i++)
//      array[i] = new Random().Next(1,32); 
// }
// int count4 = 0; 
// int CountEven (int[] array)
// {   
 
//    for ( int i = 0; i < array.Length; i++)
//       {
//              if ( array[i] % 2 == 0 )
//           {
//            Console.Write($" {string.Join(", ", array [i]  )} ");
//            count4 ++;
//           }
//       }
//    return count4;
//   }

// int count3 = 0;
// int CountOdd (int[] array)

// {
//   for ( int i = 0; i < array.Length; i++)
//       {
//              if ( array[i] % 2 == 1 )
//          {
//           Console.Write($" {string.Join(", ",   array [i]  )} ");
//           count3 ++;
//          }
//       }
//       return count3;
// }
// void FinalResult (int[] array )
//    {
//    if (count4 > count3)
//       Console.Write("Вася может рассчитывать на оценку 4");
//    else
//        Console.Write("Вася может рассчитывать на оценку 3");
//     }
// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Исходный массив: [{string.Join(", ", array )}]");
// CountEven (array);
// Console.WriteLine();
// CountOdd (array);
// Console.WriteLine();
// FinalResult (array);