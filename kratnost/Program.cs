Console.WriteLine("Введите первое число");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
double b = Convert.ToInt32(Console.ReadLine());

if (a%b == 0) Console.WriteLine("Число кратно");
else Console.WriteLine(a%b);