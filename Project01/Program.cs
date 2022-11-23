//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Clear();

int numA = int.Parse(Console.ReadLine());
int numB = int.Parse(Console.ReadLine());

if (numA == numB)
{
    Console.WriteLine("Числа одинаковые. Введите другой набор чисел.");
}

if (numA > numB)
{
    Console.Write(numA);
    Console.WriteLine(" = max");
    Console.Write(numB);
    Console.Write(" = min");
}

if (numB > numA)
{
    Console.Write(numB);
    Console.WriteLine(" = max");
    Console.Write(numA);
    Console.Write(" = min");
}