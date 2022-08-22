Console.Clear();
Console.WriteLine("Меню выбора задачи");
Console.WriteLine("Выберите номер задачи: ");

//main menu
int[] imenu = { 54, 56, 58, 60, 62 };
int i = 0;
while (i < imenu.Length)
{
    Console.WriteLine("Задача № " + imenu[i]);
    i++;
}
//additional menu
int[] addmenu = {1};
if (addmenu.Length > 0)
{
    i = 0;
    while (i < addmenu.Length)
    {
        Console.WriteLine("Задача № " + addmenu[i] + "(доп. задание)");
        i++;
    }
}

Chose:
Console.WriteLine("Введите ТОЛЬКО номер задачи: ");
int chosen = Convert.ToInt32(Console.ReadLine());

switch (chosen)
{
    case 54:
        HW_08_54();
        break;
    case 56:
        HW_08_56();
        break;
    case 58:
        HW_08_58();
        break;
    case 60:
        HW_08_60();
        break;
    case 62:
        HW_08_62();
        break;
    case 1:
        HW_08_dop1();
        break;
    default:
        Console.WriteLine("Вы указали неверный номер задачи. ");
        goto Chose;
}

void FillArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }

}

void SortRowArray(int[] rowArray)
{
    int temp;
    for (int i = 0; i < rowArray.Length; i++)
    {
        for (int j = 0; j < rowArray.Length - 1 - i; j++)
        {
            if (rowArray[j] > rowArray[j + 1])
            {
                temp = rowArray[j];
                rowArray[j] = rowArray[j + 1];
                rowArray[j + 1] = temp;
            }
        }
    }

    Console.WriteLine(string.Join("\t", rowArray));

}

int SumRow(int[] rowArray)
{
    int sum = 0;

    for (int i = 0; i < rowArray.Length; i++)
    {
        sum = sum + rowArray[i];
    }

    return sum;
}

void HW_08_54()
{
    Console.Write("Введите число строк массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число столбцов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[m, n];
    int[] rowArray = new int[n];

    Console.WriteLine("Исходная матрица: ");
    FillArray(array);

    Console.WriteLine("Измененная матрица: ");

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowArray[j] = array[i, j];
        }
        SortRowArray(rowArray);
    }
}

void HW_08_56()
{
    Console.Write("Введите число строк массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число столбцов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[m, n];
    int[] rowArray = new int[n];
    FillArray(array);

    int minRow = 0;
    int minSum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowArray[j] = array[i, j];
        }
        if (i == 0)
        {
            minSum = SumRow(rowArray);
            minRow = i;
        }
        else
        {
            if (SumRow(rowArray) < minSum)
            {
                minSum = SumRow(rowArray);
                minRow = i;
            }
        }
    }
    Console.WriteLine("Строка с наименьшей суммой элементов: " + Convert.ToInt32(minRow + 1));
}

void HW_08_58()
{
    Console.Write("Введите число строк массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число столбцов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[,] array1 = new int[m, n];
    int[,] array2 = new int[m, n];
    Console.WriteLine("Исходная матрица 1: ");
    FillArray(array1);
    Console.WriteLine("Исходная матрица 2: ");
    FillArray(array2);
    int[,] arrayResult = new int[m, n];
    Console.WriteLine("Результат произведения матриц: ");

    for (int i = 0; i < arrayResult.GetLength(0); i++)
    {
        for (int j = 0; j < arrayResult.GetLength(1); j++)
        {
            arrayResult[i, j] = array1[i, j] * array2[i, j];
            Console.Write(arrayResult[i, j] + "\t");
        }
        Console.WriteLine();
    }

}

void HW_08_60()
{
    Console.Write("Первое измерение массива: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Второе измерение массива: ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Третье измерение массива: ");
    int z = Convert.ToInt32(Console.ReadLine());

    int[,,] array = new int[x, y, z];

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int q = 0; q < z; q++)
            {
                array[i, j, q] = new Random().Next(10, 100);
                Console.WriteLine(array[i, j, q] + " (" + i + "," + j + "," + q + ")");
            }
        }
    }
}

void HW_08_62()
{
    int[,] array = new int[4, 4];
    int countPrint = 4;
    int counterArray = 1;
    int row = 0;
    int col = 0;
    int directionRow = 0;
    int directionCol = 1;
    int counterTurn = 0;
    int temp = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[row, col] = counterArray++;
        countPrint--;
        if (countPrint == 0)
        {
            if (counterTurn == 0 || counterTurn == 1)
            {
                countPrint = 3;
            }

            if (counterTurn == 2 || counterTurn == 3)
            {
                countPrint = 2;
            }

            if (counterTurn == 4 || counterTurn == 5)
            {
                countPrint = 1;
            }

            temp = directionCol;
            directionCol = -directionRow;
            directionRow = temp;

            counterTurn++;

        }
        row = row + directionRow;
        col = col + directionCol;
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void HW_08_dop1()
{
    Console.Write("Введите количество строк треуголника Паскаля: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[n, n * 2 - 1];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <= i; j++)
        {
            if (j == 0 || j == i)
            {
                array[i, j] = 1;
            }
            else
            {
                array[i, j] = array[i - 1, j - 1] + array[i - 1, j];
            }
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] != 0)
            {
                if (j == 0)
                {
                    for (int q = 0; q < array.GetLength(0) - 1 - i; q++)
                    {
                        Console.Write("   ");
                    }
                }
                Console.Write(array[i, j] + "     ");
            }
        }
        Console.WriteLine();
    }
}