/*
Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
[345, 897, 568, 234] -> 2
*/
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
Random MyRandom = new Random();
int count = 0;
Console.WriteLine("Сформированный массив:");
for (int i = 0; i < array.Length; i++)
{
    array[i] = MyRandom.Next(100, 1000);
    Console.Write("{0} ", array[i]);
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine("");
Console.WriteLine($"Количество четных чисел в массиве:{count}");