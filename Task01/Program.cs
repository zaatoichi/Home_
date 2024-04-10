// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void PrintNaturalNumbers(int a, int b)
{
    if (a <= 0) return;
    if (b <= 0) return;

        if (a < b)
            {
                PrintNaturalNumbers(a, b - 1);
                Console.Write($"{b} ");
            }
        if (a > b)
            {
                PrintNaturalNumbers(a - 1, b);
                Console.Write($"{a} ");
            }
}

Console.WriteLine("Введите натуральное число M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N:");
int n = Convert.ToInt32(Console.ReadLine());

PrintNaturalNumbers(m, n);