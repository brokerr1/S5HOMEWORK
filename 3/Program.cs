/*
Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива.
[3 7 22 2 78] -> 76
*/
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
Random MyRandom = new Random();
Console.WriteLine("Сформированный массив:");
for (int i = 0; i < array.Length; i++)
{
    array[i] = MyRandom.Next(0, 100);
    Console.Write("{0} ", array[i]);
}
Console.WriteLine("");
int min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (min > array[i])
        min = array[i];
}
Console.WriteLine("min = {0}", min);
int max = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
        max = array[i];
}
Console.WriteLine("max = {0}", max);
Console.WriteLine($"Разницу между максимальным и минимальным элементов массива:{(max - min)}");
