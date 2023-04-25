// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int numN = SetNumber(" N");
int numM = SetNumber(" M");

int SetNumber(string text)
{
    Console.Write($"Введите число{text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

if (numN > numM)
{
    for (int i = numN; i >= numM; i--)
    {
        Console.Write($" {i},");
    }
}
