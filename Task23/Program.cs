// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите целое число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Кубы чисел от 1 до {number}");
FindCube(number);

void FindCube(int numLocal)
{
    for (int i = 1; i <= numLocal; i++)
    {Console.WriteLine (Convert.ToInt32(Math.Pow(i, 3)));}
}



