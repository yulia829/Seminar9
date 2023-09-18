Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintNumber(number);
void PrintNumber(int n)
{
    if (n == 1)
        Console.Write(n + " ");
    else
    {
        Console.Write(n + " ");
        PrintNumber(n - 1);

    }
}