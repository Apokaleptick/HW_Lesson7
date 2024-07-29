void Main()
{
    int[] array = { 1, 2, 3, 4, 5 };

    Console.WriteLine("Элементы массива в обратном порядке:");
    PrintArrayReverse(array, array.Length - 1);
}

void PrintArrayReverse(int[] array, int index)
{
    if (index < 0)
    {
        return;
    }

    Console.Write(array[index] + " ");

    PrintArrayReverse(array, index - 1);
}
Main();
