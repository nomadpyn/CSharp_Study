double a, b, c, x1, x2, disc;
Console.WriteLine("Введите коэффициенты квадратного уравнения a*(x*x) + b*x +c=0 через пробел");

string[] arr = Console.ReadLine().Split();

a = Convert.ToDouble(arr[0]);
b = Convert.ToDouble(arr[1]);
c = Convert.ToDouble(arr[2]);

disc = b * b - 4 * a * c;

if (disc > 0)
{
    x1 = (-b + Math.Sqrt(disc)) / (2 * a);
    x2 = (-b - Math.Sqrt(disc)) / (2 * a);
    
    Console.WriteLine($"Корни являются вещественными и они разные\nx1 = {x1}\nx2 = {x2}");
}

else 
    if (disc == 0)
{
    x1 = (-b + Math.Sqrt(disc)) / (2 * a);

    Console.WriteLine($"Корни являются вещественными и они одинаковые\nx1 = x2 = {x1}");
}

    else
{

    Console.WriteLine($"Корней нет, т.к. дискриминант меньше нуля");
}