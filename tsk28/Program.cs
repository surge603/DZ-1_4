// Задача 28: Подсчитайте сумму цифр в числе.

Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int sum = 0;

while (a > 0)
{
    sum += a % 10;
    a /= 10;
}

Console.WriteLine($"Сумма цифр в числе: {sum}");
