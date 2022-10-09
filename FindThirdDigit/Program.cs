Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

if (N<=100) Console.WriteLine("Число не имеет третьего числа");
else 
{
    while (N>1000)
    {
        N=N/10;
    }
    Console.WriteLine(N%10);    
}