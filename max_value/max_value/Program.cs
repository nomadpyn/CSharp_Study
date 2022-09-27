Console.WriteLine("Введите три целых числа через пробел");

int max = 0;

string[] arr = Console.ReadLine().Split();


int a = int.Parse(arr[0]);
int b = int.Parse(arr[1]);
int c = int.Parse(arr[2]);

if (a >= b && a >= c)
    max = a;
if (b >= a && b >= c)
    max = b;
if (c >= a && c >= b)
    max = c;

Console.WriteLine($"Максимальное число: {max}");