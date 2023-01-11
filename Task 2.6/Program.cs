Console.Clear();
Console.Write("Введите 1-е число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b || b == a * a)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");