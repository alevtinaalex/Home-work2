Console.WriteLine("Введите трехзначное число и нажмите Enter");
int num = Convert.ToInt32(Console.ReadLine());
int b = ((num /10) % 10);
Console.Write("Вторая цифра числа ");
Console.Write(b);