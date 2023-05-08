// Console.WriteLine("Enter a number");
// int numbers = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// int count = 0;

// int GetSumNum()
// {
//   while (numbers>count)
//   {
//    count++;
//    sum+=count;
//   }

//    return sum;
// }

// int result = GetSumNum();
// Console.WriteLine(result); 







Console.WriteLine("Enter a number");
int num = Convert.ToInt32(Console.ReadLine());
int temp = 1;

for (int i = 1; i!=num+1;i++)
{
   temp = temp*i;
}
Console.WriteLine(temp);