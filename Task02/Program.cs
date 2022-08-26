// Задача 48
Console.WriteLine("Ввеедите длинну и высоту массива");
// bool row = int.TryParse(Console.ReadLine(), out int rows);
// bool col = int.TryParse(Console.ReadLine(), out int columns);
int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());


int[,] FillArray2D(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        array[i,0] = i+1;
    }

    for (int j = 1; j < columns; j++)
    {
        array[0,j] = j+1;
    }

    for (int ix = 1; ix < rows; ix++)
    {
        for (int jy = 1; jy < columns; jy++)
        {
            array[ix, jy] = array[ix,0] + array[0,jy];
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