// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int numM = SetNumber(" M");
int numN = SetNumber(" N");
int acc = Function(numM, numN);
Console.WriteLine($"Функция Аккермана A({numM},{numN}) равна {acc}");

int SetNumber(string text)
{
    Console.Write($"Введите число{text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Function(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }
    else if (numM > 0 && numN == 0)
    {
        return Function(numM - 1, 1);
    }
    else
    {
        return (Function(numM - 1, Function(numM, numN - 1)));
    }
}