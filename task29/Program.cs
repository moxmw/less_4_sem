// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = GenerateArray();

Console.WriteLine("Массив элементов:");
PrintArray(array);


static int[] GenerateArray()
{
    int[] array = new int[8];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100);
    }
    return array;
}

static void PrintArray(int[] array)
{
    Console.WriteLine($"[{String.Join(", ", array)}]");
}