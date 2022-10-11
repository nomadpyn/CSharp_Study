
double[] A = new double[5];

Console.WriteLine("Введите данные в массив");

for (int i=0;i < A.Length; i++)
{
    A[i] = double.Parse(Console.ReadLine());
}

double[,] B = new double[3, 4];

int rows = B.GetUpperBound(0)+1;
int colums = B.Length / rows;

for (int i=0; i < rows; i++)
{
    Random rnd = new Random();
    for(int j=0; j<colums; j++)
    {
        B[i, j] = rnd.NextDouble()*100;
    }
}

Console.WriteLine("Одномерный массив");

for(int i = 0; i < A.Length; i++)
{
    Console.Write("{0:F} ", A[i]);
}

Console.WriteLine("\nДвумерный массив");

for (int i = 0; i < rows; i++)
{
     for (int j = 0; j < colums; j++)
    {
        Console.Write("{0:F}\t", B[i,j]);
    }
    Console.WriteLine();
}

Console.WriteLine("Общий максимальный элемент {0:F}", getMax(A,B,rows,colums));
Console.WriteLine("Общий минимальный элемент {0:F}", getMin(A, B, rows, colums));
Console.WriteLine("Общая сумма всех элементов {0:F}", getSum(A, B, rows, colums));
Console.WriteLine("Общее произведение всех элементов {0:F}", getMult(A, B, rows, colums));
Console.WriteLine("Сумма четных элементов одномерного массива {0:F}", getSumElem(A));
Console.WriteLine("Сумма нечетных столбцов двумерного массива {0:F}", getSumElem2(B, rows, colums));

static double getMax(double[] arr1, double[,] arr2, int rows, int colums)
{
    double max = arr2[0, 0];

    for (int i = 0; i < rows; i++)
    {
       for (int j = 0; j < colums; j++)
        {
            if (arr2[i,j]> max)
                max = arr2[i,j];
        }
    }

    if (arr1.Max() > max)
        max = arr1.Max();

    return max;
}

static double getMin(double[] arr1, double[,] arr2, int rows, int colums)
{
    double min = arr2[0, 0];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            if (arr2[i, j] < min)
                min = arr2[i, j];
        }
    }

    if (arr1.Min() < min)
        min = arr1.Min();

    return min;
}

static double getSum(double[] arr1, double[,] arr2, int rows, int colums)
{
    double sum = arr1.Sum();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            sum+=arr2[i, j];
        }
    }

    return sum;
}

static double getMult(double[] arr1, double[,] arr2, int rows, int colums)
{
    double mult = 1;

    for (int i =0; i< arr1.Length; i++)
    {
        mult *= arr1[i];
    }

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            mult *= arr2[i, j];
        }
    }

    return mult;
}

static double getSumElem(double[] arr)
{
    double sum = 0;

    for(int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
            sum += arr[i];
    }

    return sum;
}

static double getSumElem2(double[,] arr, int rows, int colums)
{
    double sum = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            if(j%2==0)
                sum+=arr[i, j];
        }
    }

    return sum;
}