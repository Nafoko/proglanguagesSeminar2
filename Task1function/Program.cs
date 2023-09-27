// Решение задачи с промощью функции
int number = new Random().Next(10, 99);
Console.WriteLine($"Случайное число из отрезка [10, 99] -> {number}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}