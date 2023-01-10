Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 — это перевод из строки в число
Console.WriteLine($"Результат: {n * n}"); // $"...:{}" — это интерполяция строк, чтобы не складывать строку с числом
