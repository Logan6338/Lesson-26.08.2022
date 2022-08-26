// Задача 49
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
            if((i%2==0)&&(j%2==0))
            {
                array[i, j] = Convert.ToInt32(Math.Pow(random.Next(10), 2));
            }
            else
            {
                array[i, j] = random.Next(10);
            }
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

PrintArray2D(FillArray2D(rows, columns));