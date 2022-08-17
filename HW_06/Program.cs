Console.Clear();
Console.WriteLine("Меню выбора задачи");
Console.WriteLine("Выберите номер задачи: ");

//main menu
int[] imenu = { 41, 43 };
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
    case 41:
        HW_06_41();
        break;
    case 43:
        HW_06_43();
        break;
    case 1:
        HW_06_dop1();
        break;
    default:
        Console.WriteLine("Вы указали неверный номер задачи. ");
        goto Chose;
}


void HW_06_41()
{
    Console.Write("Введите размер массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    int[] array = new int[m];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Число " + Convert.ToString(i + 1) + " ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0) count++;
    }
    Console.WriteLine("Чисел больше нуля: " + count);
}

void HW_06_43()
{
    Console.Write("b1 = ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("k1 = ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("b2 = ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("k2 = ");
    double k2 = Convert.ToInt32(Console.ReadLine());

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine("( " + x + " , " + y + " )");
}

void HW_06_dop1()
{
    Console.Write("Введите строк и столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[n,n];
    Console.WriteLine("Исходный массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
            Console.Write($"{array[i, j]} ");   
        }
        Console.WriteLine();
    }
    
    Console.WriteLine("Транспонированный массив: ");
    Transposition(array);

}

void Transposition(int[,] arrayTr)
{
    int temp = arrayTr[0,0];

    for (int i = 0; i < arrayTr.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            temp = arrayTr[i, j];
            arrayTr[i, j] = arrayTr[j, i];
            arrayTr[j, i] = temp;
        }
    }
    
    for (int i = 0; i < arrayTr.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTr.GetLength(1); j++)
        {
            Console.Write($"{arrayTr[i, j]} "); 
        }
         Console.WriteLine();
    }

}