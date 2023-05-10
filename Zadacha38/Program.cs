// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
Console.Write("Введите колличество чисел массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] Array = GetArray(length, min, max);
Console.WriteLine($"[{string.Join(",", Array)}]");
FindNumberDifference(Array, min, max);

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

void FindNumberDifference(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < max)
        {
            max = array[i];
        }
         if (array[i] > min)
        {
            min = array[i];
        }
    }
    Console.WriteLine($"Разница между максимальным и минимальным элементом {max - min}");
}