// Задача 4. Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

// Первый способ:
/*int i = (-1) * n;

while (i <= n)
{
    Console.Write($"{i} ");
    i++;
}*/

// Второй способ:
for (int i = (-1) * n; i <= n; i++)
    Console.Write($"{i} ");