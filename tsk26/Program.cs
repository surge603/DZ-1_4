// Задача 26: Возведите число А в натуральную степень B, используя цикл.

Console.Clear();
Console.Write("Введите основание степени: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите значание степени: ");
int b = int.Parse(Console.ReadLine());

int result = 1;
for (int i = 1; i <= b; i++)
{
    result *= a;
}

Console.WriteLine($"{a}^{b} = {result}");