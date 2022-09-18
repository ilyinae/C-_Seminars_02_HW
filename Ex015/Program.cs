// Задача 15: Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите номер дня недели");
int i = Convert.ToInt32(Console.ReadLine());
if (i == 6 || i == 7)
    Console.WriteLine("Выходной");
else
    Console.WriteLine("Трудовые будни");