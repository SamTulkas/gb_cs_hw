Console.Clear();
Console.WriteLine("Меню выбора задачи");
Console.WriteLine("Выберите номер задачи: ");

//main menu
int[] imenu = { 19, 21, 23 };
int i = 0;
while (i < imenu.Length)
{
    Console.WriteLine("Задача № " + imenu[i]);
    i++;
}
//additional menu
int[] addmenu = { 1 };
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
    case 19:
        HW_03_19();
        break;
    case 21:
        HW_03_21();
        break;
    case 23:
        HW_03_23();
        break;
    case 1:
        HW_03_dop1();
        break;
    default:
        Console.WriteLine("Вы указали неверный номер задачи. ");
        goto Chose;
}


void HW_03_19()
{
    Console.WriteLine("Введите 5 значное число: ");
    string Nstring = Console.ReadLine();

    if (Nstring.Length != 5)
        Console.WriteLine("Ошибка! Введено не пятизначное число!");
    else
    {
        int i = 0;
        bool res = true;
        while (i < Nstring.Length / 2)
        {
            if (Nstring[i] != Nstring[Nstring.Length - 1 - i])
                res = false;
            break;
            i++;
        }
        if (res)
            Console.WriteLine("Число является палиндромом");
        else
            Console.WriteLine("Число НЕ является палиндромом");
    }
}

void HW_03_21()
{
    Console.WriteLine("Введите координаты первой точки (X,Y,Z)");
    int x1 = Convert.ToInt32(Console.ReadLine());
    int y1 = Convert.ToInt32(Console.ReadLine());
    int z1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координаты второй точки (X,Y,Z)");
    int x2 = Convert.ToInt32(Console.ReadLine());
    int y2 = Convert.ToInt32(Console.ReadLine());
    int z2 = Convert.ToInt32(Console.ReadLine());

    double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1)));

    Console.WriteLine("Расстоние между точками = " + Convert.ToString(distance));

}

void HW_03_23()
{
    Console.WriteLine("Введите число до которого необходимо высчитать кубы:");
    int N = Convert.ToInt32(Console.ReadLine());

    int i = 1;

    while (i <= N)
    {
        Console.WriteLine(i * i * i);
        i++;
    }

}

void HW_03_dop1()
{
    int[] A = {1,2,3,4,5,6,7,0,8,9,10};
    int i = 0;

    int max = A[0];
    int premax = A[0];
    while (i < A.Length)
    {
        if (A[i] == 0)
            break;
        if (A[i] > max)
            {
                premax = max;
                max = A[i];
            }
        i++;    
    }
    Console.WriteLine(premax);
}
