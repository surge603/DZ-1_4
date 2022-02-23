// Задача 32: Задайте массив из восьми элементов, заполненных нулями и единицами. Выведите их на экран

Console.Clear();
int[] arr = new int[8];

for (int i = 0; i < 8; i++)
{
    arr[i] = new Random().Next(0, 2);
}

for (int i = 0; i < 8; i++)
{
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();