Console.Clear();

Console.WriteLine("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine());

if (day > 7)
{
    Console.WriteLine("Invalid param");
    return;
}

if (day == 6 || day == 7)
{
    Console.WriteLine("Сегодня выходной");
}
else
{
    Console.WriteLine("Сегодня не выходной");
}