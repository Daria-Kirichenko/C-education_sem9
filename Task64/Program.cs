// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNTo1(int n)
{
    if(n < 1) return;
    Console.Write(n + " ");
    PrintNTo1(n - 1);
}

int number = ReadNumber("Введите число:");
PrintNTo1(number);