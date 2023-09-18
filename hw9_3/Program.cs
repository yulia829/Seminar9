Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чтсло N: ");
int n = Convert.ToInt32(Console.ReadLine());

int ak(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return ak(n - 1, 1);
    else
        return ak(n - 1, ak(n, m - 1));
}

Console.WriteLine($"Функция Аккермана равно: {ak(m, n)} ");