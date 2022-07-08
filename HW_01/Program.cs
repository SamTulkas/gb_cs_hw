Console.Clear();
Console.WriteLine("Меню выбора задачи");
Console.WriteLine("Выберите номер задачи: ");

int imenu = 2;
while (imenu <= 8)
{
    Console.WriteLine("Задача № "+imenu);
    imenu = imenu + 2;
}
Chose:
Console.WriteLine("Введите ТОЛЬКО номер задачи: ");
int chosen = Convert.ToInt32(Console.ReadLine());

switch (chosen)
{
    case 2:
        HW_01_02();
        break;
    case 4:
        HW_01_04();
        break;
    case 6:
        HW_01_06();
        break;
    case 8:
        HW_01_08();
        break;
    default:
        Console.WriteLine("Вы указали неверный номер задачи. ");
        goto Chose;
}

void HW_01_02()
{
    Console.WriteLine("Введите первое число:");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int b = Convert.ToInt32(Console.ReadLine());

    if (a>b)
        Console.WriteLine("max = "+a);
    else
        Console.WriteLine("max = "+b);
}

void HW_01_04()
{
    Console.WriteLine("Введите первое число:");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число:");
    int b = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Введите третье число:");
    int c = Convert.ToInt32(Console.ReadLine()); 

    int max = a;

    if (b > max) max = b;
    if (c > max) max = c;
    Console.WriteLine("max = "+max);
}

void HW_01_06()
{
    Console.WriteLine("Введите число:");
    int a = Convert.ToInt32(Console.ReadLine());

    if (a % 2 == 0) 
        Console.WriteLine("Да");
    else
        Console.WriteLine("Нет");   
}

void HW_01_08()
{
    Console.WriteLine("Введите число:");
    int a = Convert.ToInt32(Console.ReadLine());

    int i = 1;
    bool printed = false;

    while (i <= a)
    {
        if (i % 2 == 0) 
        {
            Console.Write(i);
            printed = true;
        }
        else
            printed = false; 
        i++;
        if (i < a && printed)  
            Console.Write(",");
        else
            Console.Write("");    
    }
    Console.WriteLine("");
}