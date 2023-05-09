
// int[] numArr = new int[12];
// int positiveNum=0;
// int negNum=0;
// for(int i=0;i<numArr.Length;i++)
// {
//    numArr[i] = new Random().Next(-9, 10);

//    if(numArr[i]>0)
//    {
//       positiveNum+=numArr[i];
//    }
//    else
//    {
//       negNum+=numArr[i];
//    }
// }

// Console.WriteLine(String.Join(",", numArr)+ " \nсумма положительных "+positiveNum+" сумма отрицательных "+ negNum);



// int[] numArr = new int[]{1, 7898,66,-6,-52,0};

// Console.WriteLine(String.Join(",", numArr));

// for(int i=0;i<numArr.Length;i++)
// {
//    numArr[i]=-numArr[i];
// }

// Console.WriteLine(String.Join(",", numArr));


Console.WriteLine("Enter a number");
int num = Convert.ToInt32(Console.ReadLine());
int[] numArr = new int[] {1,345,12,34,56};
Console.WriteLine(String.Join(",", numArr));
bool flag = false;

for(int i=0;i<numArr.Length;i++)
{
   if (numArr[i]==num)
   {
flag=true;
break;
   }
   
}

if(flag==true)

{
Console.WriteLine("Yes");

}
else 
{
   Console.WriteLine("No");
}
