// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int numM = SetNumber(" M");
int numN = SetNumber(" N");
int tmp = GetSum(numM, numN);
Console.WriteLine($"Сумма чисел от {numM} до {numN} равна {tmp}");

int SetNumber(string text)
{
    Console.Write($"Введите число{text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int GetSum(int numM, int numN)
{
    int tmp = 0;
    if (numM < numN)
    {
        for (int i = numM; i <= numN; i++)
        {
            tmp = tmp + i;
        }
    }
    return tmp;
}


