Console.Clear();
Console.WriteLine("Меню выбора задачи");
Console.WriteLine("Выберите номер задачи: ");

//main menu
int[] imenu = { 10, 13, 15 };
int i = 0;
while (i < imenu.Length)
{
    Console.WriteLine("Задача № " + imenu[i]);
    i++;
}
//additional menu
int[] addmenu = { 1, 2 };
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
    case 10:
        HW_02_10();
        break;
    case 13:
        HW_02_13();
        break;
    case 15:
        HW_02_15();
        break;
    case 1:
        HW_02_dop1();
        break;
    case 2:
        HW_02_dop2();
        break;
    default:
        Console.WriteLine("Вы указали неверный номер задачи. ");
        goto Chose;
}

void HW_02_10()
{
    int a = new Random().Next(100, 1000);

    Console.WriteLine(Convert.ToString(a) + " -> " + Convert.ToString(a)[1]);
}

void HW_02_13()
{
    int a = new Random().Next(1, 10000);

    Console.WriteLine(a);
    string strA = Convert.ToString(a);

    if (strA.Length > 2) Console.WriteLine(strA[2]);
    else Console.WriteLine("Третей цифры нет");
}

void HW_02_15()
{
    int a = new Random().Next(1, 8);
    Console.WriteLine(a);

    if (a >= 6) Console.WriteLine("Да, это выходной");
    else Console.WriteLine("Нет, это рабочий день");
}

void HW_02_dop1()
{
    Console.WriteLine("Введите сумму вклада");
    int X = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите процент");
    float P = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите желаемую итоговую сумму");
    int Y = Convert.ToInt32(Console.ReadLine());

    float curSum = X;
    int years = 0;

    while (curSum < Y)
    {
        curSum = curSum * (1 + (P / 100));
        years++;
    }

    Console.WriteLine("Результат будет через " + Convert.ToString(years));
}

void HW_02_dop2()
{
    Console.WriteLine("Введите расстояние в первый день");
    int X = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите итоговое расстояние");
    int P = Convert.ToInt32(Console.ReadLine());

    double curDis = X;
    int days = 1;

   while (curDis < P)
   {
        curDis = curDis*1.15;
        days++;
   }

    Console.WriteLine("Результат будет через " + Convert.ToString(days));
}
