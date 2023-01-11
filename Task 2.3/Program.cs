Console.Clear();

string? s = Console.ReadLine(); // ? — убираем желтое предупреждение
Console.WriteLine(Convert.ToInt32(s[0].ToString()) * 5);
// s[0] — символ строки
// ToString() — перевод в строку
// Convert.ToInt32 — перевод из строки в число по UTF-8

