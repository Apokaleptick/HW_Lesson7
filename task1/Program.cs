void Main()
{
    int M = 5;
    int N = 10;

    Console.WriteLine($"Натуральные числа в промежутке от {M} до {N}: ");
    PrintNumbersInRange(M, N);
}

static void PrintNumbersInRange(int M, int N)
{

    if (M > N)
    {
        return;
    }

    Console.Write(M + " ");
    PrintNumbersInRange(M + 1, N);
}
Main();

