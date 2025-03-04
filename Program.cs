 
 
 System.Console.WriteLine("please input any three number numbers");
 
 System.Console.WriteLine("please input the 1st number numbers");
 int x = int.Parse(Console.ReadLine());

 System.Console.WriteLine("please input the 2nd number numbers");
 int y = int.Parse(Console.ReadLine());

 System.Console.WriteLine("please input the 3rd number numbers");
 int z = int.Parse(Console.ReadLine());

 int result = SumOfThreeNumbers(x, y, z);
 System.Console.WriteLine(result);

 
 
 static int SumOfThreeNumbers(int a, int b, int c)
 {
   return a + b + c;
 }

