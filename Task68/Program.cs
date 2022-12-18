// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите два НЕотрицательных числа, чтобы увидеть результат функции Аккермана для них:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

if (m<0 | n<0)
{
    Console.WriteLine("Вычисление невозможно. Оба числа должны быть больше или равны 0!");
}
else
{
    Console.WriteLine($"Результат вычисления функции Аккермана для {m} и {n} равно {Akkerman(m,n)}");
}

int Akkerman(int m, int n)
{
    if (m == 0) 
    {
        return n+1;
    }
    if (m != 0 && n == 0) 
    {
        return Akkerman(m-1,1);
    }
    if (m > 0 && n > 0)   
    {
        return Akkerman(m-1,Akkerman(m,n-1));
    }
    return Akkerman(m,n);
}
