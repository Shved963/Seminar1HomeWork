//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Clear();

int numA = int.Parse(Console.ReadLine());
int numB = int.Parse(Console.ReadLine());
int numC = int.Parse(Console.ReadLine());


if (numA > numB & numA > numC )
{
    Console.Write("max = ");
    Console.Write(numA);
}
else
{
    if (numB > numC)
    {
        Console.Write("max = ");
        Console.Write(numB);
    }
    else
    {
        Console.Write("max = ");
        Console.Write(numC);
    }
}
//Программа выводит максимальное число, даже если два из трех или все числа одинаковые