Console.Clear();
Console.WriteLine("Меню выбора задачи");
Console.WriteLine("Выберите номер задачи: ");

//main menu
int[] imenu = { 25, 27, 29 };
int i = 0;
while (i < imenu.Length)
{
    Console.WriteLine("Задача № " + imenu[i]);
    i++;
}
//additional menu
int[] addmenu = { 1 , 2};
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
    case 25:
        HW_04_25();
        break;
    case 27:
        HW_04_27();
        break;
    case 29:
        HW_04_29();
        break;
    case 1:
        HW_04_dop1();
        break;
    case 2:
        HW_04_dop2();
        break;
    default:
        Console.WriteLine("Вы указали неверный номер задачи. ");
        goto Chose;
}


void HW_04_25()
{

    Console.Write("Введите число А: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число B: ");
    int b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Результат : " + Math.Pow(a, b));

}

void HW_04_27()
{
     Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int sum = 0;

    while(number > 1)
    {
        sum += number % 10;
        number = number / 10;
    }

    Console.WriteLine(sum);

}

void HW_04_29()
{

    int[] array = new int[8];
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите значение элемента номер " + i + ": ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("[" + string.Join(",", array) + "]");

}

void HW_04_dop1()
{
    int[] array = new int[100];
    int firstLocalMax = 0;
    int distance = 0;
    int minDistant = 0;

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите " + i + "-ый элемент: ");
        array[i] = Convert.ToInt32(Console.ReadLine());

        if (array[i] == 0)
        {
            break;
        }
    }
    
    for(int j = 1; j < array.Length - 1; j++)
    {
        if (array[j] == 0)
        {
            break;
        }

        if (array[j] > array[j - 1] && array[j] > array[j + 1])
        {
            if(firstLocalMax != 0)
            {
                distance = j - firstLocalMax;
                if (minDistant == 0 || distance < minDistant)
                {
                    minDistant = distance;
                }
            }
            
            firstLocalMax = j;
            j++;
            
        }
    }

    Console.WriteLine("Минимальная дистанция: " + minDistant);
}

void HW_04_dop2()
{
    Console.Write("Введите кол-во кустов (от 3 до 1000): ");
    int quantity = Convert.ToInt32(Console.ReadLine());
    int amount = 0;
    int tempAmount = 0;
    

    while(quantity < 3 || quantity > 1000)
    {
        Console.Write("Ошибка, указано неверное значени! Введите кол-во кустов (от 3 до 1000): ");
        quantity = Convert.ToInt32(Console.ReadLine());
    }
    int[] array = new int[quantity];

    for(int i = 0; i < quantity; i++)
    {
        Console.Write("Введите кол-во ягод на  " + i + "-ом кусте: ");
        array[i] = Convert.ToInt32(Console.ReadLine());

    }

    for(int j = 0; j < array.Length; j++)
    {
        if(j == 0)
        {
            amount = array[array.Length - 1] + array[j] + array[j + 1];
            continue;
        }
        else if(j == array.Length - 1)
        {
            tempAmount = array[j - 1] + array[j] + array[0];
        }
        else
        {
            tempAmount = array[j - 1] + array[j] + array[j + 1];
        }

        if (tempAmount > amount)
        {
            amount = tempAmount;
        }
    }

    Console.WriteLine("Максимум можно собрать: " + amount);

}
