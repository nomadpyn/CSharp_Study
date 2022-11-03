Console.WriteLine("Введите число от 1 до 100");
int digit = Int32.Parse(Console.ReadLine());

if(digit<1 || digit > 100)
{
    Console.WriteLine("Вы ввели неправильное число");
}
else
{
    if (digit % 3 != 0 && digit%5 !=0)
    {
        Console.WriteLine(digit);
    }
    else
    {
        if(digit % 3 == 0 && digit % 5 == 0)
        {
            Console.WriteLine("Fizz Buzz");
        }
        else
        {
            if (digit % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine("Buzz");
            }
        }
    }
}