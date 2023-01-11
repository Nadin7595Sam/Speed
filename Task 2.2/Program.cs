Console.Clear();

int n = new Random().Next(100, 1000); // [begin, end + 1] [100, 999]
Console.WriteLine($"Случайное число: {n}");

// Первый способ:
/*int n1 = n / 100; //кол-во сотен
int n2 = n / 10; // кол-во десятков
int n3 = n % 10; // кол-во единиц

Console.WriteLine($"{n1}{n3}");*/

// Второй способ:
int n1 = n / 100; //кол-во сотен
int n3 = n % 10; // кол-во единиц

Console.WriteLine(n1 * 10 + n3);