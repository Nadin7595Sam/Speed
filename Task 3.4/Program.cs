Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
    // 1-й вариант
    //Console.Write($"{i * i} ");

    // 2-й вариант
    Console.Write($"{Math.Pow(i, 2)} ");