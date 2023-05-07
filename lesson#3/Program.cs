// Console.WriteLine ("Enter a first number");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Enter a first number");
// int y = Convert.ToInt32(Console.ReadLine());


// if(x>0 && y>0)
// {
// Console.WriteLine ("1 Четверть");
// }
// else if(x<0 && y>0)
// {
// Console.WriteLine ("2 Четверть");
// }
// else if(x<0 && y<0)
// {
// Console.WriteLine ("3 Четверть");
// }
// else if(x>0 && y<0)
// {
// Console.WriteLine ("4 Четверть");
// }
// else
// {
// Console.WriteLine ("Точка находится на одной или двух координат");
// }


// Console.WriteLine ("Enter a first number");
// int num = Convert.ToInt32(Console.ReadLine());



// if(num ==1)
//  {
//  Console.WriteLine ("1 Четверть");
//  Console.WriteLine ("x>0 && y>0");
//  }
//  else if(num ==2)
//  {
//  Console.WriteLine ("2 Четверть");
//   Console.WriteLine ("x<0 && y>0");
//  }
//  else if(num ==3)
//  {
//  Console.WriteLine ("3 Четверть");
//  Console.WriteLine ("x<0 && y<0");
//  }
//  else if(num ==4)
//  {
//  Console.WriteLine ("4 Четверть");
//  Console.WriteLine ("x>0 && y<0");
//  }
//  else
//  {
//  Console.WriteLine ("Точка находится на одной или двух координат");
//  }



Console.WriteLine ("Enter a first number");
int num = Convert.ToInt32(Console.ReadLine());

switch(num)
{
   case 1: 
   {
     Console.WriteLine ("1 Четверть");
     Console.WriteLine ("x>0 && y>0");
     break;
   }
      case 2: 
   {
     Console.WriteLine ("2 Четверть");
     Console.WriteLine ("x<0 && y>0");
     break;
   }
      case 3: 
   {
    Console.WriteLine ("3 Четверть");
    Console.WriteLine ("x<0 && y<0");
     break;
   }
      case 4: 
   {
    Console.WriteLine ("4 Четверть");
     Console.WriteLine ("x>0 && y<0");
     break;
   }
   default:
   {
      
   Console.WriteLine ("такой четверти нет");
   break;
   }
}



// if(num ==1)
//  {
//  Console.WriteLine ("1 Четверть");
//  Console.WriteLine ("x>0 && y>0");
//  }
//  else if(num ==2)
//  {
//  Console.WriteLine ("2 Четверть");
//   Console.WriteLine ("x<0 && y>0");
//  }
//  else if(num ==3)
//  {
//  Console.WriteLine ("3 Четверть");
//  Console.WriteLine ("x<0 && y<0");
//  }
//  else if(num ==4)
//  {
//  Console.WriteLine ("4 Четверть");
//  Console.WriteLine ("x>0 && y<0");
//  }
//  else
//  {
//  Console.WriteLine ("Точка находится на одной или двух координат");
//  }