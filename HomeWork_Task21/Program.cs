// Задача 21. Программа принимает на вход координаты двух точек
// находит расстояние между ними в 3D пространстве.
// Проверочные примеры: A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53.

Console.Write("Введите координату х первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату z первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату х второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((x2 - x1)*(x2 - x1)+(y2 - y1)*(y2 - y1)+(z2 - z1)*(z2 - z1));

Console.WriteLine("Расстояние между точками, в 3D-пространстве, равно {0: #.##}",result);
