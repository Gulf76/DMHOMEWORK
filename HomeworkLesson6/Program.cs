/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/


// int count = 0;
// int InputArray (int[] array )

// {
//   for ( int i = 0; i < array.Length; i++)
//      {
//         array[i] = new Random().Next(-10,32); 
        
//         if (  array[i]  > 0)
//             count++;
//      }
//      return count;

// }

// Console.Clear();
// Console.Write("Введите кол-во элементов массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"Исходный массив:   [{string.Join(", ", array )}]");
// Console.WriteLine($"Чисел больше нуля: [{count }]");    



/*
 Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
 уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)   
*/

// Console.Clear();
// Console.Write("Введите значения b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значения k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введите значения b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значения k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());
// double x = (b2 - b1)/(k2 - k1);
// double y = k2*x +b2 ;
// if ( (k1 * x) + b1 == (k2 * x) + b2)
// {
// y = (k1 * x) + b1;
// }
// else
// {
// x = ((b2 - b1)/(k2 - k1))*-1;
// y = (k1 * x) + b1;
// }
// Console.WriteLine(x);
// Console.Write(y);


/*
По целочисленным координатам вершин 
треугольника (x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь.

Входные данные
Входной файл INPUT.TXT содержит 6 целых чисел x1,y1,x2,y2,x3,y3 – координаты вершин треугольника. Все числа не 
превышают 106 по абсолютной величине.
*/

// Console.Clear();
// Console.Write("Ведите координату X1: "); 
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Ведите координату Y1: "); 
// double y1 = Convert.ToDouble(Console.ReadLine()); 
// Console.Write("Ведите координату X2: "); 
// double x2 = Convert.ToDouble(Console.ReadLine()); 
// Console.Write("Ведите координату Y2: "); 
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Ведите координату X3: "); 
// double x3 = Convert.ToDouble(Console.ReadLine()); 
// Console.Write("Ведите координату Y3: "); 
// double y3 = Convert.ToDouble(Console.ReadLine());

 
// double a =  Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
// double b =  Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
// double c =  Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
// Console.WriteLine("Сторона треугольника  a  =  " + Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
// Console.WriteLine("Сторона треугольника  b  =  " + Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2)));
// Console.WriteLine("Сторона треугольника  c  =  " + Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2)));

// double p = ( a + b + c) / 2;
// double S =  Math.Round ( Math.Sqrt ( p * ( p - a) * ( p - b ) * ( p - c)),1);
// Console.WriteLine("Площадь треугольника  S  =  "  + S );
