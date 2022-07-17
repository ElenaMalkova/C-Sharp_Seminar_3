// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Напишите пятизначное число");
string number = Console.ReadLine();

string PalindromTest(string numLocal)
{
    if (numLocal.Length > 5 | numLocal.Length < 5) return "Число введено некорректно";
    if (numLocal[0] == numLocal[4] && numLocal[1] == numLocal[3]) return "Палиндром";
    return "Не палиндром";
}
Console.WriteLine(PalindromTest(number));