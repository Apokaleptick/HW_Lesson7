void Main()
{
    System.Console.Write("Введите начальное значение M: ");
    int M = Convert.ToInt32(Console.ReadLine());

    System.Console.Write("Введите конечное значение N: ");
    int N = Convert.ToInt32(Console.ReadLine());

    if (M >= N)
    {
        System.Console.WriteLine("N должен быть больше M");
    }
    else
    {
        PrintNumbers(M, N);
    }
}

void PrintNumbers(int M, int N)
{
    if (M > N)
        return;

    System.Console.WriteLine(M);
    PrintNumbers(M + 1, N);

}
Main();