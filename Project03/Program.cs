﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
//(делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.Clear();
Console.WriteLine("Введите любое число");

int num = int.Parse(Console.ReadLine());


if (num % 2 == 0)
{
    Console.Write(num);
    Console.Write(" - четное число");
}
else
{
    Console.Write(num);
    Console.Write(" - нечетное число");
}