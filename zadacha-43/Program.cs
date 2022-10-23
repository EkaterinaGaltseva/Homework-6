/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.Write("Введите значение b1: ");
string B1 = Console.ReadLine();
double b1 = double.Parse(B1);

Console.Write("Введите значение k1: ");
string K1 = Console.ReadLine();
double k1 = double.Parse(K1);

Console.Write("Введите значение b2: ");
string B2 = Console.ReadLine();
double b2 = double.Parse(B2);

Console.Write("Введите значение k2: ");
string K2 = Console.ReadLine();
double k2 = double.Parse(K2);

double x = (b2 - b1)/(k1 - k2);
double y = k1 * x + b1;

Console.Write($"Координаты точки пересечения: ({x}, {y})");
