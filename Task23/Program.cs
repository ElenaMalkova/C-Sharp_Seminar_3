﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите целое число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine();

int FindCube(int iLocal)
{
    
    return  Convert.ToInt32(Math.Pow(iLocal, 3));
}
for (int i = 1; i <= number; i++)
{
    Console.WriteLine(FindCube(i));
}



