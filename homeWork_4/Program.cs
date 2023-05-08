/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
// Console.WriteLine("Enter A");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter B");
// int numberB = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Степень " + Math.Pow(numberA, numberB));

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

// int number = ReadInt("Введите число: ");
// int len = NumberLen(number);
// SumNumbers(number, len);



// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }


// int NumberLen(int a)
// {
//     int index = 0;
//     while (a > 0)
//     {
//         a /= 10;
//         index++;
//     }
//     return index;
// }

// void SumNumbers(int n, int len)
// {
//     int sum = 0;
//     for (int i = 1; i <= len; i++)
//     {
//         sum += n % 10;
//         n /= 10;
//     }
//     Console.WriteLine(sum);
// }



/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

// Console.WriteLine("Enter 9 numbers");
// int num = Convert.ToInt32(Console.ReadLine());


// int [] numArr = new int [8];
// for (int i=0;i<numArr.Length;i++)
// {
//    numArr[i] += Convert.ToInt32(Console.ReadLine());
   
// }
//    Console.Write("Массив: ");
//    Console.WriteLine(String.Join(",", numArr));



