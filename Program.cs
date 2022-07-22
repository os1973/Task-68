/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29
*/

static int A(int n, int m)
    {
        if (n < 0 || m < 0) throw new ArgumentOutOfRangeException();
        if (n == 0) return m + 1;
        if (m == 0) return A(n - 1, m);
        return A(n - 1, A(n, m - 1));
    }
    static void Main(string[] args)
    {
        Console.WriteLine(A(2, 5));
        Console.WriteLine(A(1, 2));
    }
