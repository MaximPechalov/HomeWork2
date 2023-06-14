Console.Clear();

Console.WriteLine("Введите число трёхзначное число: ");
int num = int.Parse(Console.ReadLine());

if (num < 100 || num > 999)
{
    Console.WriteLine("Неверное число");
    return;
}

int result = num % 100;
int result2 = result / 10;
Console.WriteLine($"Вторая цифра числа: {result2}");