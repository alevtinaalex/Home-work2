Console.WriteLine("Введите число и нажмите Enter");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99)
 {
   int a = num % 10;
   int index = 2;
   int chis = num.ToString()[index] - '0';
    if (chis >= 0)
     {
     Console.WriteLine("Третья цифра в числе");
     Console.WriteLine(chis);
     }
  }
else
   {
      Console.WriteLine("Третьей цифры в этом числе нет");
   } 
