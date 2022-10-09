Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

if (N>=10 && N<100)
{
    int firsDigit = N/10;
    int secondDigit = N%10;

    int max;

    if (firsDigit>=secondDigit) Console.WriteLine(firsDigit);
    else Console.WriteLine(secondDigit);    
}