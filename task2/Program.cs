void Main()
{
    System.Console.Write("Введите неотрицательное значение m: ");
    int m = Convert.ToInt32(Console.ReadLine());

    System.Console.Write("Введите неотрицательное значение n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    if (m < 0 || n < 0)
    {
        System.Console.WriteLine("Числа должны быть неотрицательными.");
    }
    else if (m > 5)
    {
        System.Console.WriteLine("Значение m слишком велико и может привести к переполнению. Пожалуйста, введите m не более 5.");
    }
    else
    {
        int result = Ackermann(m, n);
        System.Console.WriteLine($"Ackermann({m}, {n}) = {result}");
    }
}

int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Ackermann(m - 1, 1);
    else
        return Ackermann(m - 1, Ackermann(m, n - 1));
}
Main();