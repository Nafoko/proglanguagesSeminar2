// Программа, которая принимает на вход
// трехзначное число и на выходе покахывает вторую цифру этого числа.


Console.WriteLine ($"Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int secondDigit = SecondDigit(number);
Console.WriteLine($"{number} -> {secondDigit}");

int SecondDigit(int num)
{
    int firstDigit = number / 100;
    int lastDigit = number % 10;
    int numResult = number / 10 - lastDigit;
    return numResult;
}


