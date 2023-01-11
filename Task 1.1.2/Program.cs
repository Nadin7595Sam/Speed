// Задача 2. Напишите программу,
// которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Введите 1-е число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-е число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
    Console.WriteLine($"max = {a}");
else if (b > a && b > c)
    Console.WriteLine($"max = {b}");
else
    Console.WriteLine($"max = {c}");