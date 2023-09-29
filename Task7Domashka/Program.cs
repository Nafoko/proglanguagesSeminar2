// Задача 13: Напишите программу, которая 
// выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

int Promt (String message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetThirdRank(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool ValidateNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}

int number = Promt("Введите число > ");
if (ValidateNumber(number));
{
    Console.WriteLine(GetThirdRank(number));
}
    

// int thirdNumber = ThirdNumber(number);
// Console.WriteLine($"{number} -> {thirdNumber}");

// int checkNumber = CheckNumber(number);
// Console.WriteLine($"{number} -> {CheckNumber}");


// int ThirdNumber(int number)
// {
//     while (number > 999)
//     {
//         number /= 10;
//     }
//     return number % 10;
// }

// int CheckNumber(int number)
// {
//     if (number < 100)
//     {
//         Console.WriteLine($"Трертьей цифры нет");
//         return ;

//     }
// }
