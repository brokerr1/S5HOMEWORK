/*
Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
Random MyRandom = new Random();
int sum = 0;
Console.WriteLine("Сформированный массив:");
for (int i = 0; i < array.Length; i++)
{
    array[i] = MyRandom.Next(0, 100);
    Console.Write("{0} ", array[i]);
    if (i % 2 == 1)
    {
        sum = sum + array[i];
    }
}
Console.WriteLine("");
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях.:{sum}");
