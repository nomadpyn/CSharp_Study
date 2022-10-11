
int[] A = new int[5];

Console.WriteLine("Введите данные в массив");

for (int i=0;i < A.Length; i++)
{
    A[i] = Int32.Parse(Console.ReadLine());
}

int[,] B = new int[3, 4];

int rows = B.GetUpperBound(0)+1;
int colums = B.Length / rows;

for (int i=0; i < rows; i++)
{
    Random rnd = new Random();
    for(int j=0; j<colums; j++)
    {
        B[i, j] = rnd.Next(1, 100);
    }
}

Console.WriteLine("Одномерный массив");

for(int i = 0; i < A.Length; i++)
{
    Console.Write($"{A[i]} ");
}

Console.WriteLine("\nДвумерный массив");

for (int i = 0; i < rows; i++)
{
     for (int j = 0; j < colums; j++)
    {
        Console.Write($"{B[i,j]}\t");
    }
    Console.WriteLine();
}

Console.WriteLine("Общий максимальный элемент " + getMax(A,B,rows,colums));
Console.WriteLine("Общий минимальный элемент " + getMin(A, B, rows, colums));
Console.WriteLine("Общая сумма всех элементов " + getSum(A, B, rows, colums));
Console.WriteLine("Общее произведение всех элементов " + getMult(A, B, rows, colums));
Console.WriteLine("Сумма четных элементов одномерного массива " + getSumElem(A));
Console.WriteLine("Сумма нечетных столбцов двумерного массива " + getSumElem2(B, rows, colums));

static int getMax(int [] arr1, int [,] arr2, int rows, int colums)
{
    int max = arr2[0, 0];

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

static int getMin(int[] arr1, int[,] arr2, int rows, int colums)
{
    int min = arr2[0, 0];

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

static int getSum(int[] arr1, int[,] arr2, int rows, int colums)
{
    int sum = arr1.Sum();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            sum+=arr2[i, j];
        }
    }

    return sum;
}

static int getMult(int[] arr1, int[,] arr2, int rows, int colums)
{
    int mult = 1;

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

static int getSumElem(int[] arr)
{
    int sum = 0;

    for(int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
            sum += arr[i];
    }

    return sum;
}

static int getSumElem2(int[,] arr, int rows, int colums)
{
    int sum = 0;

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