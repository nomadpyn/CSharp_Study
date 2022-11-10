byte a = 0;
byte b = 0;

try
{
    Console.WriteLine("Введите число А");
    a = checked(byte.Parse(Console.ReadLine()));
    Console.WriteLine(a);
    Console.WriteLine("Введите число B");
    b = checked(byte.Parse(Console.ReadLine()));
    Console.WriteLine(b);
}
catch(Exception e)
{
    Console.WriteLine(e.Message) ;
}

Sum(a, b);
Diff(a, b);
Mult(a, b);
Divide(a, b);

 void Sum(byte a, byte b)
{
    
    try
    {
        Console.WriteLine($"Сумма двух чисел {checked((byte)(a + b))}");
    }
    catch(OverflowException e)
    {
        Console.WriteLine("Ошибка при сумме двух чисел");
        Console.WriteLine(e.Message);
    }
}

void Diff(byte a, byte b)
{
    try
    {
        Console.WriteLine($"Разность двух чисел {checked((byte)(a - b))}");
    }
    catch (OverflowException e)
    {
        Console.WriteLine("Ошибка при разности двух чисел");
        Console.WriteLine(e.Message);
    }
}

void Mult(byte a, byte b)
{
    try
    {
        Console.WriteLine($"Произведение двух чисел {checked((byte)(a * b))}");
    }
    catch (OverflowException e)
    {
        Console.WriteLine("Ошибка при умножении двух чисел");
        Console.WriteLine(e.Message);
    }
}
void Divide(byte a, byte b)
{
    try
    {
        Console.WriteLine($"Делени двух чисел {checked((byte)(a / b))}");
    }
    catch (OverflowException e)
    {
        Console.WriteLine("Ошибка при делении двух чисел");
        Console.WriteLine(e.Message);
    }
    catch(DivideByZeroException ez)
    {
        Console.WriteLine("Ошибка при делении на ноль");
        Console.WriteLine(ez.Message);
    }
}