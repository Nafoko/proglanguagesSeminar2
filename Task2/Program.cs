// Напишите программу котоаря выводит Случайное 
// трехзначное число и удаляет вторую цифру этого числа

int number = new Random().Next(100, 1000);
int firstDigit = number / 100;
int lastDigit = number % 10;
int numResult = firstDigit * 10 + lastDigit;
Console.WriteLine($"{number} -> {numResult}");
