// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Задания выполняются только с помощью рекурсий!

Console.WriteLine("Введите два числа, чтобы увидеть сумму натуральных элементов в промежутке между этими числами (включая их):");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;

if (m<n)
{
    NumSum(m,n,sum);
}
else
{
    NumSum(n,m,sum);
}


void NumSum(int m, int n, int sum)
{
    if (m>n)
    {
        Console.WriteLine($". Их сумма равна {sum}");
        return;
    }
    sum = sum + m;
    Console.Write(m +" ");
    m++;
    NumSum(m,n,sum);
}