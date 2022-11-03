Console.WriteLine("Введите число");
int digit = Int32.Parse(Console.ReadLine());

Console.WriteLine("Введите процент");
int percent = Int32.Parse(Console.ReadLine());

int result = digit * percent/100;

Console.WriteLine(result);