Console.Clear();
Console.WriteLine("Меню выбора задачи");
Console.WriteLine("Выберите номер задачи: ");

//main menu
int[] imenu = { 34, 36, 38 };
int i = 0;
while (i < imenu.Length)
{
    Console.WriteLine("Задача № " + imenu[i]);
    i++;
}
//additional menu
int[] addmenu = {};
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
    case 34:
        HW_05_34();
        break;
    case 36:
        HW_05_36();
        break;
    case 38:
        HW_05_38();
        break;
    default:
        Console.WriteLine("Вы указали неверный номер задачи. ");
        goto Chose;
}


void HW_05_34()
{
    Console.Write("Введите размерность массива: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[n];
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        if (array[i] % 2 == 0) count++;
    }
    Console.WriteLine("[" + string.Join(", ", array) + "]");
    Console.WriteLine("Количество чётных чисел в массиве: " + count);
}

void HW_05_36()
{
    Console.Write("Введите размерность массива: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[n];
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }

   for(int j = 1; j < array.Length; j += 2)
    {
        sum += array[j];
    }

    Console.WriteLine("[" + string.Join(", ", array) + "]");
    Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + sum);
}

void HW_05_38()
{
    Console.Write("Введите размерность массива: ");
    int n = Convert.ToInt32(Console.ReadLine());

    double[] array = new double[n];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Число "+ Convert.ToString(i+1) + " ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }

    double max = array[0];
    double min = array[0];

     for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    Console.WriteLine("[" + string.Join(",  ", array) + "]");
    Console.WriteLine("Разница между максимальным и минимальным элементов массива " + Convert.ToString(max - min));
}