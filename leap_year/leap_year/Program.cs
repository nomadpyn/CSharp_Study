
Console.WriteLine("Введите год для проверки");

int year = int.Parse(Console.ReadLine());

string output;

if (year % 4 == 0)
{
    if (year % 100 == 0)
    {
        if (year % 400 == 0)
            output = "високосный";
        else
            output = "невисокосный";
    }

    else
        output = "високосный";
}
else
    output = "невисокосный";

Console.WriteLine($"Год {year} {output}");