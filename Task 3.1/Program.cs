// task 17

Console.Clear();
Console.Write("Введите координату x: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y: ");
double y = Convert.ToDouble(Console.ReadLine());

while (x == 0)
{
    Console.Write("Вы ошиблись!\nВведите координату x: ");
    x = Convert.ToDouble(Console.ReadLine());
}

while (y == 0)
{
    Console.Write("Вы ошиблись!\nВведите координату y: ");
    y = Convert.ToDouble(Console.ReadLine());
}

if (x > 0 && y > 0)
    Console.WriteLine("I");
else if (x < 0 && y > 0)
    Console.WriteLine("II");
else if (x < 0 && y < 0)
    Console.WriteLine("III");
else
    Console.WriteLine("IV");