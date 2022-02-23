// Задача 30: Покажите кубы чисел, заканчивающихся на чётную цифру.

Console.Clear();
Console.Write("Введите максимум цикла: ");
int max = int.Parse(Console.ReadLine());
for (int i = 0; i <= max; i++)
{
    int cube = i * i * i;
    int last_dig = cube % 10;
    if (last_dig / 2 * 2 == last_dig)
    {
        Console.WriteLine($"Четный куб: {i}^3 = {cube} ");
    }
}
