Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

if (N<0) N*=(-1);

Console.WriteLine();
for (int i = 1; i<=N; i++)
{
    if (i==1) Console.WriteLine(i);
    if (i%2==0) Console.WriteLine(i);
}