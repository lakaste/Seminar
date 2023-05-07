// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Enter a first number");
int num = Convert.ToInt32(Console.ReadLine());
int a = (num % 100) / 10;


Console.WriteLine("Итоговое число " + a);

