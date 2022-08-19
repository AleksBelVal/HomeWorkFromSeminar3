// Программа принимает на вход число (N)
// выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0)
{   
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"{i}\t{i * i * i}");
    }
}
else Console.WriteLine("Число имеет не корректное значение");
