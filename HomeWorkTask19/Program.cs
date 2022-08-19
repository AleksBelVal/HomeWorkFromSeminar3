// Задача 19. Программа принимает на вход пятизначное число
// проверяет является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число для проверки: ");
int numA = Convert.ToInt32(Console.ReadLine());
int num5 = numA / 10000;
int num1 = numA % 10;
int num4 = numA / 1000 % 10;
int num2 = numA % 100 / 10;

if (num1 == num5 && num2 == num4)
    Console.WriteLine("Число является полиндромом");
else
    Console.WriteLine("Число не является полиндромом");
