
int[] numArr = new int[12];
int positiveNum=0;
int negNum=0;
for(int i=0;i<numArr.Length;i++)
{
   numArr[i] = new Random().Next(-9, 10);

   if(numArr[i]>0)
   {
      positiveNum+=numArr[i];
   }
   else
   {
      negNum+=numArr[i];
   }
}

Console.WriteLine(String.Join(",", numArr)+ " \nсумма положительных "+positiveNum+" сумма отрицательных "+ negNum);