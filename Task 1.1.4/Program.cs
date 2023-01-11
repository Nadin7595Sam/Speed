// Задача 4. Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

// Первый способ:

for (int i = 2; i <= n; i += 2)
    Console.Write($"{i} ");