/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

// Console.WriteLine("Enter a number ");
// string number = Console.ReadLine();
// int pal = number.Length;

// if (pal == 5)
// {
//  if (number[0] == number[4] && number[1] == number[3])
//     {
//  Console.WriteLine($"{number} - Палиндром");
//     }
//  else
//     {
//  Console.WriteLine($"{number} - НЕ палиндром");
//     }
// }
// else
// {
//  Console.WriteLine($"ERROR: {number} - не является пятизначным");
// }


/*
Задача 21 (branch task_2)
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

// int x1 = ReadInt("enter the coordinates X of the first point: ");
// int y1 = ReadInt("enter the coordinates Y of the first point: ");
// int z1 = ReadInt("enter the coordinates Z of the first point: ");
// int x2 = ReadInt("enter the coordinates X of the second point: ");
// int y2 = ReadInt("enter the coordinates Y of the second point: ");
// int z2 = ReadInt("enter the coordinates Z of the second point: ");

// int a = x2 - x1;
// int b = y2 - y1;
// int c = z1 - z2;

// double length = Math.Sqrt(a * a + b * b + c * c);
// Console.WriteLine($"Length of the segment {length}");



// int ReadInt(string message)
// {
//   Console.Write(message);
//   return Convert.ToInt32(Console.ReadLine());
// }





/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

// int number = ReadInt("Enter a number: ");

// for (int i = 1; i <= number; i++)
// { 
//  Console.Write($"{i*i*i} ");
// }


// int ReadInt(string message)
// {
//  Console.Write(message);
//  return Convert.ToInt32(Console.ReadLine());
// }
