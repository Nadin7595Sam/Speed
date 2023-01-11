Console.Clear();

// Первый вариант:
/*int a = new Random().Next(1, 11);
Console.WriteLine(a);
int b = new Random().Next(1, 11);
Console.WriteLine(b);
int c = a % b;

if (a % b == 0)
    Console.WriteLine("Кратно");
else
    Console.WriteLine("Не кратно");
    Console.WriteLine($"Остаток: {c}");*/

// Второй вариант:
Console.Write("Введите 1-е число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a % b == 0)
    Console.WriteLine("Кратно");
else
    Console.WriteLine($"Не кратно. Остаток: {a % b}");