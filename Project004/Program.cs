// Напишите программу, которая на вход принимает одно число (N) а на выходе показывает все целые числа в промежутке от -N до N
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = (-1) * n; i <= n; i+=2)
    Console.Write(i + " ");