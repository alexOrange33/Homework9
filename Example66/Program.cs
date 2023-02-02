// Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


System.Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);
if(m == n) System.Console.WriteLine(m+" = "+n+" -> промежутка между числами нет");
else if (m > n) System.Console.WriteLine(m+" > "+n+" -> m должно быть меньше n");
else System.Console.WriteLine($"m = {m}; n = {n} -> {Sum(m,n)}");


//--------------metods-----------

int Sum(int m, int n)
{
    if (m == n - 1) return m + n;
    return (m + Sum(m + 1, n));
}