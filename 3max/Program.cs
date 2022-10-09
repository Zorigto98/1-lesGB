Console.WriteLine("Введите первой число");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе  число");
double b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
double c = Convert.ToInt32(Console.ReadLine());

double max;

if (a>=b) max=a;
else max=b;

if (max<=c) c = max;

Console.Write("Максимальное число: ");
Console.WriteLine(max);