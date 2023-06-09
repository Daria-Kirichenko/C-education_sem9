﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// Например, m = 2, n = 3 -> A(m,n) = 9

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}



int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    else if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return Akkerman(m, n);
}


int m = ReadNumber("Введите число m:");
int n = ReadNumber("Введите число n:");
int result = Akkerman(m, n);
Console.WriteLine(result);