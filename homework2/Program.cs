// // Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два
// // неотрицательных числа m и n.

static int ackermann(int m, int n)
{
if (m == 0)
{
return n + 1;
}
else if (m > 0 && n == 0)
{
return ackermann(m - 1, 1);
}
else if (m > 0 && n > 0)
{
return ackermann(m - 1, ackermann(m, n - 1));
}
return -1;
}
Console.Write(ackermann(0, 0));


Console.Write("Введите первое неотрицательное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе неотрицательное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0)
{
Console.Write("Введите неотрицательные числа!");
}
else
{
Console.Write(ackermann(m, n));
}