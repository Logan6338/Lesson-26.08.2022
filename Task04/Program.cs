// 51 задача
Console.WriteLine("Возвести в квадрат числа, у которых оба индекса четные");

Console.WriteLine("Ввеедите длинну и высоту массива");
// bool row = int.TryParse(Console.ReadLine(), out int rows);
// bool col = int.TryParse(Console.ReadLine(), out int columns);
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());


int[,] FillArray2D(int rows, int columns)
{

    int[,] array = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(10);
        }
    }

    return array;
}

void PrintArray2D(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }

        Console.WriteLine();
    }
}

int SummaArrayDiagonal(int[,]arr)
{
    int summa = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(i==j)
            {
                summa+=arr[i,j];
            }
        }
    }
    return summa;
    
}

int[,] array = FillArray2D(rows, columns);

PrintArray2D(array);
Console.WriteLine(SummaArrayDiagonal(array));
