/* Задача 21. Напишите программу, которая принимает на вход координаты
 двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

void distancePoints (double x1, double y1, double z1, double x2, double y2, double z2)
{
    System.Console.WriteLine(Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1)));
}

Console.WriteLine("Введите координату Х первой точки: ");
double x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y первой точки: ");
double y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z первой точки: ");
double z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату X второй точки ");
double x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y второй точки ");
double y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z второй точки ");
double z2 = int.Parse(Console.ReadLine()!);



distancePoints(x1, y1, z1, x2, y2, z2);