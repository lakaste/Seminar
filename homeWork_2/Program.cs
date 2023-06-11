// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Enter a first number");
// int num = Convert.ToInt32(Console.ReadLine());
// int a = (num % 100) / 10;

// Console.WriteLine("Итоговое число " + a);



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int number = ReadInt("Введите число: ");
// int count = number.ToString().Length;
// Console.Write(MakeArray(number, count));

// int ReadInt(string message)
// {
//      Console.Write(message);
//      return Convert.ToInt32(Console.ReadLine());
//  }

//  int MakeArray(int a, int b)
//  {
//  int result = 0;
//      if (b < 3)
//      {
//          Console.Write("Третьей цифры нет, держи: ");
//      }
//      else
//      {
//          int c = 1;
//          for (int i = b; i > 3; i--)
//          {
//              c = c * 10;
//          }

//          result = (a / c) % 10;
//      }
//  return result;
//  }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("enter a number ");
int number = Convert.ToInt32(Console.ReadLine());
if (number==1)
{
    Console.WriteLine("No");
 }
 else if (number==2)
 {
    Console.WriteLine("No");
 }
 else if (number==3)
 {
    Console.WriteLine("No");
 }
 else if (number==4)
 {
    Console.WriteLine("No");
 }
 else if (number==5)
 {
    Console.WriteLine("No");
 }
 else if (number==6)
 {
    Console.WriteLine("Yes");
 }
 else if (number==7)
 {
    Console.WriteLine("Yes");
 }

 else
 {
    Console.WriteLine("ERROR");
 }