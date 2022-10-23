/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

Console.Write("Введите элементы через пробел :");

int[] array = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
int count = array.Count(X => X >0);
Console.Write($"Чисел больше 0 -> {count}");