Console.Clear();
Console.WriteLine("Меню выбора задачи");
Console.WriteLine("Выберите номер задачи: ");

//main menu
int[] imenu = { 47, 50, 52 };
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
    case 47:
        HW_07_47();
        break;
    case 50:
        HW_07_50();
        break;
    case 52:
        HW_07_52();
        break;
    case 1:
        HW_07_dop1();
        break;
    default:
        Console.WriteLine("Вы указали неверный номер задачи. ");
        goto Chose;
}


void HW_07_47()
{
    Console.Write("Введите число строк массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число столбцов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * new Random().Next(-20, 21);
            Console.Write(Math.Round(array[i, j], 2) + "\t");
        }
        Console.WriteLine();
    }
}

void HW_07_50()
{
    Console.Write("Введите число строк массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число столбцов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.Write("Введите номер строки искомого значения: ");
    int rowCount = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите номер столбца искомого значения: ");
    int colCount = Convert.ToInt32(Console.ReadLine());

    if (rowCount > m || colCount > n)
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine("Искомое значение: " + array[rowCount - 1, colCount - 1]);
    }
}

void HW_07_52()
{
    Console.Write("Введите число строк массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число столбцов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }

    Console.WriteLine("Среднее арифметическое элементов в каждом столбце: ");

    double result;
    int count;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        result = 0;
        count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result = result + array[i, j];
            count++;
        }
        Console.Write(Math.Round(result / count, 2) + "\t");
    }
}

void HW_07_dop1()
{
    Console.Write("Введите число строк массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число столбцов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int temp;

    Console.WriteLine("Исходная матрица: ");

    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }

    Console.WriteLine("Транспонированная матрица: ");

    for (int i = 0; i < array.GetLength(0)/2; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp = array[i, j];
            array[i, j] = array[array.GetLength(0) - 1 - i, j];
            array[array.GetLength(0) - 1 - i, j] = temp;
        }
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