// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ack(int a, int b)
{
    if (a == 0) return b + 1;
    else if (b == 0) return Ack(a - 1, 1);
    else return Ack(a - 1, Ack(a, b - 1));
}

Console.WriteLine("Введите неотрицательное число M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите неотрицательное число N:");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"{Ack(m, n)}");