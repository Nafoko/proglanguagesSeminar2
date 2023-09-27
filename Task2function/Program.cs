int number = new Random().Next(100, 1000);
int deleteSecondDigit = DeleteSecondDigit(number);
Console.WriteLine($"{number} -> {deleteSecondDigit}");
int DeleteSecondDigit(int num)
{
    int firstDigit = number / 100;
    int lastDigit = number % 10;
    int numResult = firstDigit * 10 + lastDigit;
    return numResult;
}
