Console.Write("Введите первое число: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int xb = Convert.ToInt32(Console.ReadLine());
if (xb == xa * xa)
    Console.WriteLine("Второе число является квадратом первого");
else
    Console.WriteLine("Второе число не является квадратом первого");  