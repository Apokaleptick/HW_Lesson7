void Main()
{
    Console.Write("Введите количество элементов массива: ");
    int length = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[length];
    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(1, 101);
    }
    System.Console.Write("Начальный массив:");
    PrintArray(array, 0);
    System.Console.WriteLine();

    Console.Write("Элементы массива в обратном порядке:");
    PrintArrayInReverse(array, length - 1);
    System.Console.WriteLine();
}

void PrintArray(int[] array, int index)
{
    if (index >= array.Length)
        return;

    Console.Write(array[index]);
    if (index < array.Length - 1)
    {
        Console.Write(", ");
    }
    PrintArray(array, index + 1);
}
void PrintArrayInReverse(int[] array, int index)
{
    if (index < 0)
        return;

    Console.Write(array[index]);
    if (index > 0)
    {
        System.Console.Write(", ");
    }
    PrintArrayInReverse(array, index - 1);
}
Main();