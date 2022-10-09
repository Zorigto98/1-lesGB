Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

if (N<0) N*=(-1);

for (int i = N*(-1); i<=N; i++)
{
    Console.WriteLine(i);
}