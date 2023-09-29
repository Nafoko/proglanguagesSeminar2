// 10. Программа, которая принимает на вход
// трехзначное число и на выходе покахывает вторую цифру этого числа.


Console.WriteLine ($"Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int secondDigit = SecondDigit(number);
Console.WriteLine($"{number} -> {secondDigit}");

int SecondDigit(int num)
{
    int firstDigit = number / 10; //из 467 остается 46
    int numResult = firstDigit % 10;
    return numResult;
}


