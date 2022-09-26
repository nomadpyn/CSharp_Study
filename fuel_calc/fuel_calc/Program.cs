Console.WriteLine("Простая программа расчета среднего расхода топлива");
Console.Write("Введите расстояние (км): ");

double dist = Convert.ToDouble(Console.ReadLine());

Console.Write("Потрачено топлива (л): ");

double vol = Convert.ToDouble(Console.ReadLine());

double cons = (vol * 100) / dist;

string output = string.Format("Автомобиль прошел {0:F} км, потратил {1:F} литров топлива. Средний расход - {2:F} л / 100 км.", dist, vol, cons);

Console.WriteLine(output);


