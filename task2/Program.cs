void Main()
{

    int m = 3;
    int n = 7;

    Console.WriteLine($"Функция Аккермана A({m}, {n}) = {Acker(m, n)}");
}

int Acker(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Acker(m - 1, 1);
    }
    else
    {
        return Acker(m - 1, Acker(m, n - 1));
    }
}
Main();