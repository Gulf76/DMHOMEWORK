// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Clear();
 Console.Write("Введите число: ");
 int n = Convert.ToInt32(Console.ReadLine());
 //int i = 2;
  while ( n <= 1 )
{
     Console.Write("Вы ошиблись!\nВведите число больше единицы: ");
     n = Convert.ToInt32(Console.ReadLine());    
}
//   while ( i <= n )
// {
//      {Console.Write($"{i} ");
//      i += 2;}
// }
for ( int i = 2; i <= n; i+=2)
          Console.Write($"{i} ") ;

