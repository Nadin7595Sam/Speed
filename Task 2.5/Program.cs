Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

// Первый вариант:
/*if (a % 7 == 0 && a % 23 == 0)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");*/

// Второй вариант:
if (a % 7 == 0)
{
    if (a % 23 == 0)
        Console.WriteLine("Да");
    else
        Console.WriteLine("Нет");
}
else
    Console.WriteLine("Нет");