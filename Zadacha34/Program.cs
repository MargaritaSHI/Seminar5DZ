// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.Write("Введите колличество чисел массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] Array = GetArray(length, min, max);
Console.WriteLine($"[{string.Join(",", Array)}]");
FindQuantity(Array);

int[] GetArray(int size, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(min, max + 1);
    }
    return result;
}

void FindQuantity(int[] array)
{
    int guantity = 0;
    for (int i = 0; i < array.Length; i++)

    {
        if (array [i] % 2 == 0)
        guantity = guantity + 1;
    }
    Console.WriteLine($"Колличество четных чисел в массиве {guantity}");
}


