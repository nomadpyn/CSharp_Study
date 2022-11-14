
Point A = new Point(0, 0);
Point B = new Point(2, 3);
Console.WriteLine(A);
Console.WriteLine(B);
Line Al = new Line(A, B);
Console.WriteLine(Al);
Console.WriteLine("Длина прямой {0:F}", Al.Length());

Line Bl = new Line(1, 1, 15, 7);
Console.WriteLine(Bl);
Console.WriteLine("Длина прямой {0:F}", Bl.Length());