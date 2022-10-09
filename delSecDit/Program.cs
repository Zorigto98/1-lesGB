Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

if (N>=100 && N<1000)
{
    int firstDigit = N/100;
    int thirdDigit = N%10;
    Console.WriteLine(firstDigit*10 + thirdDigit);    
}