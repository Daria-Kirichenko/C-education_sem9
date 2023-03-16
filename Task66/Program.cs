// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SummaryMToN(int m, int n)
{
    if(n < m) return 0;
    int sum = n + SummaryMToN(m, n - 1);
    return sum;
}

int numberM = ReadNumber("Введите значение М:");
int numberN = ReadNumber("Введите значение N:");

int summary = SummaryMToN(numberM, numberN);
Console.WriteLine(summary);